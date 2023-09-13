using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace SoftWell.Fpml.Pure.Tests;

[TestClass]
public class SerializerCreationTests
{
    private static readonly XmlSerializerFactory _xmlSerializerFactory = new();

    [TestInitialize]
    public void Initialize()
    {
        // TurnOnAllExceptionsTexts();
    }

    [TestMethod]
    public void Should_CreateSerializerForAll_ConfirmationTypes()
    {
        TestAssembly(typeof(SoftWell.Fpml.Confirmation.DataDocument).Assembly);
    }

    [TestMethod]
    public void Should_CreateSerializerForAll_PretradeTypes()
    {
        TestAssembly(typeof(SoftWell.Fpml.Pretrade.DataDocument).Assembly);
    }

    private static void TestAssembly(Assembly assembly)
    {
        using var writer = new StreamWriter(Console.OpenStandardOutput());

        var tts = assembly.GetTypes().Where(x => x.IsClass && x.IsPublic);
        var errors = new List<string>();
        foreach (var t in tts)
        {
            if (IsError(t))
            {
                errors.Add(t.FullName!);
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

    private static void TurnOnAllExceptionsTexts()
    {
        AppDomain.CurrentDomain.FirstChanceException += (_, args) =>
        {
            using var writer = new StreamWriter(Console.OpenStandardOutput());
            writer.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            writer.WriteLine(args.Exception.ToString());
            writer.Flush();
        };
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