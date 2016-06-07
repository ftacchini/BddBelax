"C:\Program Files (x86)\NUnit.org\nunit-console\nunit3-console.exe" /out=TestResult.txt /result=TestResult.xml /framework=net-4.0 MathOperations.AcceptanceTests\bin\Debug\AccptanceTests.dll
 
"%~dp0\packages\SpecFlow.2.1.0\tools\specflow.exe" nunitexecutionreport MathOperations.AcceptanceTests\MathOperations.AcceptanceTests.csproj
 
IF NOT EXIST TestResult.xml GOTO FAIL
IF NOT EXIST TestResult.html GOTO FAIL
EXIT
 
:FAIL
echo ##teamcity[buildStatus status='FAILURE']
EXIT /B 1