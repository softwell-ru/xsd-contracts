@echo off

..\..\build_tools/xsd.exe ./xml.xsd ./spfifix.xsd ./fpml/fpml-main-5-12.xsd ./fpml/xmldsig-core-schema.xsd /classes /namespace:FpML.SPFI_FIX

echo "Now you should replace [][] manually!!!!"