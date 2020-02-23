# Xunit_Basic
Example write testcases in xunit
## 1. Install libs
Install packages:
```
XunitPractice -> packages.config
```

## 2. Run the test
Run the tests with dotnet command line, and we will get the xml result file:
(Run command at project directory)
```
dotnet test --logger:"xunit;LogFilePath=test-result.xml"
```

## 3. Transform xml result to html file
Use Transform tool (SaxonHE package) to parse xml to html rely on format of xsl file.
You move to place that Transform tool was installed, and use the command at below.
```
Transform.exe -o:"<your output directory>\test-report.html" -s:"<your xml result file directory>\test-result.xml" -xsl:"<your xsl file directory>\xml_to_html.xsl"
```
