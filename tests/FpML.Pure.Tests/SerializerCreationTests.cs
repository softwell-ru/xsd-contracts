using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using FpML.Confirmation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FpML.Pure.Tests;

[TestClass]
public class SerializerCreationTests
{
    private static readonly XmlSerializerFactory _xmlSerializerFactory = new();

    [TestMethod]
    public void Should_CreateSerializerForAllConfirmationTypes()
    {
        // uncomment to see all exceptions thrown
        // AppDomain.CurrentDomain.FirstChanceException += (_, args) =>
        // {
        //     using var writer = new StreamWriter(Console.OpenStandardOutput());
        //     writer.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        //     writer.WriteLine(args.Exception.ToString());
        //     writer.Flush();
        // };

        var assembly = typeof(DataDocument).Assembly;

        using var writer = new StreamWriter(Console.OpenStandardOutput());

        var tts = assembly.GetTypes().Where(x => x.IsClass);
        var errors = new List<string>();
        foreach (var t in tts)
        {
            if (IsError(t))
            {
                errors.Add(t.FullName);
                writer.WriteLine($"{t.FullName} error");
                writer.Flush();
            }
            // else
            // {
            //     writer.WriteLine($"{t.FullName} ok");
            //     writer.Flush();
            // }
        }

        if (errors.Any())
        {
            Assert.Fail("Could't create serializer for: " + string.Join(", ", errors));
        }
    }

    private static bool IsError(Type t)
    {
        try
        {
            var ser = _xmlSerializerFactory.CreateSerializer(t);
            return false;
        }
        catch (PlatformNotSupportedException)
        {
            return true;
        }
    }
}