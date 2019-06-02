@echo off

rem A sample script that sets the classpath, compiles an application and runs it.

setlocal

set libdir="C:\Program Files\prosys-opc-ua-java-sdk-3.1.4-514-client-server-evaluation\lib"
set bindir=.\bin
set srcdir=.

set CP=%libdir%\prosys-opc-ua-java-sdk-client-server-evaluation-3.1.4-514.jar;%libdir%\opc-ua-stack-1.3.344-173.jar;%libdir%\log4j-1.2.17.jar;%libdir%\bcprov-jdk15on-1.54.jar;%libdir%\bcpkix-jdk15on-1.54.jar;%libdir%\httpclient-4.5.2.jar;%libdir%\httpcore-4.4.4.jar;%libdir%\httpcore-nio-4.4.4.jar;%libdir%\slf4j-api-1.7.7.jar;%libdir%\slf4j-log4j12-1.7.7.jar

if not defined JAVA_HOME (
echo JAVA_HOME environment variable must be set!
EXIT /B 1
)

rem Ensure that the path is guarded with hyphens
if exist "%JAVA_HOME%" set JAVA_HOME="%JAVA_HOME%"

if not exist %JAVA_HOME%\bin\javac.exe (
echo could not find 'javac' in %%JAVA_HOME%%\bin\
EXIT /B 2
)

if not exist %bindir%\fi\aalto\demo\server\DemoServer.class %JAVA_HOME%\bin\javac -classpath %CP% %srcdir%\fi\aalto\demo\server\*.java 

%JAVA_HOME%\bin\java -classpath %bindir%;%CP% fi.aalto.demo.server.DemoServer %1 %2 %3

:END
endlocal 
EXIT /B 0
