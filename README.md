<h1 align="center">Web Calculator</h1>

<div align="center">

[![Status](https://img.shields.io/badge/status-active-success.svg)]()

</div>


## 📝 Table of Contents

- [Getting Started](#getting_started)
- [Preparations](#preparations)
- [Installing](#installing)
- [Running the tests](#tests)
- [Usage](#usage)
- [TODO](#TODO)
- [Authors](#authors)

## 🏁 Getting Started <a name = "getting_started"></a>

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See [Preparations](#preparations) for notes on how to deploy the project on a live system.
<br>
(Эти инструкции помогут вам запустить и запустить копию проекта на вашем локальном компьютере для целей разработки и тестирования. См. [Preparations](#preparations) для заметок о том, как развернуть проект в действующей системе.)

## Preparations <a name = "preparations"></a>
What things you need to install
<BR>
(Что нужно для установки)

```
.NET Runtime 5.0.17 https://dotnet.microsoft.com/en-us/download/dotnet/5.0

Microsoft.NET.Test.Sdk --version 17.2.0 https://www.nuget.org/packages/Microsoft.NET.Test.Sdk/

Xunit https://xunit.net/docs/getting-started/netcore/cmdline

K6 https://k6.io/docs/getting-started/installation/
```

### Installing <a name = "installing"></a>
To install this project on your local device, you need to download a copy from this repository
<BR>
(Чтобы установить этот проект на локальное устройство, вам необходимо скачать копию из этого репозитория.)
```
https://github.com/NovaStrikeexe/TESRCALC
```
Once in the directory of this reposition, before launching the application, you must open the ../TESRCALC/TestNetCalc directory and execute in the terminal command: "dotnet build" in it to build the project. <br>To run the project you need to run in the terminal command "dotnet run"
In the terminal, you should see the following lines:
```
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:5000
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: https://localhost:5001
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: ../TESRCALC/TestNetCalc
```
Their appearance will mean that the project is launched
<br>

(Оказавшись в каталоге этого репозитория, перед запуском приложения необходимо открыть каталог ../TESRCALC/TestNetCalc и выполнить в терминале команду: "dotnet build" для сборки проекта. <br>Для запуска проекта нужно запустить в терминале команду "dotnet run"

В терминале вы должны увидеть следующие строки:
```
СМ. листинг выше
```
Их появление будет означать, что проект запущен)


## 🔧 Running the tests <a name = "tests"></a>

This project has two types of tests
<br>
Load and Unit
<br>
The load test is carried out using the K6 framework The test itself is located in the K6 directory and to run it, you must use the command:

```
k6 run K6_Https_Test.js
```
Unit tests are located in the TestNetCalc.Tests directory to run them you need to use xunit.runner.visualstudio as well as a extention for your IDE for Xunit tests

For exemple for vscode .NET Core Test Explorer

(Этот проект имеет два типа тестов
<br>
Нагрузка и единица измерения
<br>
Нагрузочный тест проводится с помощью фреймворка K6 Сам тест находится в каталоге K6 и для его запуска необходимо использовать команду:

```
СМ. листинг выше
```
Модульные тесты расположены в каталоге TestNetCalc.Tests, для их запуска вам необходимо использовать xunit.runner.visualstudio, а также расширение для вашей IDE для тестов Xunit.

Например, для vscode .NET Core Test Explorer)

## 🎈 Usage <a name="usage"></a>

This calculator is able to work with operations Addition Subtraction Multiplication and Division (But only with two numbers)
<br>
(Данный калькулятор работает с операциями Сложения Вычитания Умножения и Деления (Но только с двумя числами))

## ✍️ TODO <a name = "TODO"></a>
In the future, it is planned to refine the application for use with more complex expressions.
<br>
(В дальнейшем планируется доработать приложение для использования с более сложными выражениями.)
## Author <a name = "author"></a>
[@NovaStrikeexe](https://github.com/NovaStrikeexe) - Initial work

