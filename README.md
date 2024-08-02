# ExcelDataReplacing

A Windows Forms application for replacing data in Excel files using the EPPlus library.

## Features

- Select and read data from two source Excel files.
- Match data based on specified columns.
- Update a target Excel file with matched data.
- Download the updated Excel file.

## Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) (version used in your project)
- [Visual Studio](https://visualstudio.microsoft.com/)

## Installation

### Install EPPlus Package

To handle Excel files, this project uses the [EPPlus](https://www.nuget.org/packages/EPPlus/) library. Follow these steps to add EPPlus to your project:

1. Open your project in Visual Studio.
2. Go to `Tools` -> `NuGet Package Manager` -> `Manage NuGet Packages for Solution`.
3. In the `Browse` tab, search for `EPPlus`.
4. Select the `EPPlus` package and click `Install`.
5. Confirm any prompts to complete the installation.

## Usage

1. Run the application.
2. Select the first source file by clicking the "Select First Source" button and choose an Excel file.
3. Select the second source file by clicking the "Select Second Source" button and choose an Excel file.
4. Select the Tezz Delivery file by clicking the "Select Tezz Delivery" button and choose an Excel file.
5. Enter the column names for the barcode, price, and matching columns.
6. Click the "Replace" button to start the replacement process.
7. Once the process is complete, you can download the updated Tezz Delivery file by clicking the "Download" button.
8. To clear the selections and start over, click the "Clear" button.
