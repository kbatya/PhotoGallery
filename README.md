# PhotoGallery
# MAUI Beginner Task: Simple Photo Gallery

## Overview

This project is a beginner-friendly task designed for those new to **.NET MAUI**. It involves creating a simple photo gallery application with 8 pictures and navigation buttons. The gallery allows users to navigate through the images using **"Up"** and **"Down"** buttons.

## Features
# Registration Page

## Table of Contents
1. [Overview](#overview)
2. [Screen Design](#screen-design)
3. [Model Creation](#model-creation)
4. [Screen Implementation](#screen-implementation)
5. [Validation Rules](#validation-rules)
6. [Requirements](#requirements)
7. [How to Run](#how-to-run)

## Screen Design
The registration screen includes the following elements:
- Image element (background/title)
- Input fields for:
  - Name
  - Username
  - Email address
  - Phone number
  - Password
  - Date of birth
- Label for displaying the calculated age
- Labels for error messages
- Registration button



## Model Creation
a `User` class was defined in the `Models` folder implements `INotifyPropertyChanged` for data binding
with the following properties:
   - Name
   - Username
   - Email
   - Phone
   - Password
   - Date of Birth
   - Read-only Age (calculated)
      .

## Screen Implementation
The screen named `RegistrationPage`.

![Scatch of the Screen](https://github.com/kbatya/PhotoGallery/blob/master/registrationScatch.png)
![Screenshot of the Android Emulator](https://github.com/kbatya/PhotoGallery/blob/master/registrationScreen.png)
## Validation Rules
1. All fields are requared
2. The username cannot start with a digit and cannot contain spaces.
3. The password must contain at least one uppercase letter and one number.
4. The age must be greater than 18 years.

Appropriate red color error message will be displayed for each validation failure  

- **Dynamic and Static UI Creation**: Demonstrates two ways of creating UI:
  - **Dynamic in Code**: The navigation of pictures is designed from the first picture to the last.
  - **Static in XAML**: The navigation of images is designed in a circular way.
- **Simple Navigation**: Use the **"Up"** and **"Down"** buttons to navigate through the gallery of images.
- **User-Friendly Interface**: The navigation buttons are enabled or disabled based on the current image index to provide a smooth user experience.
- **Icon Fonts for Navigation**: The application uses icon fonts for the `Text` property of the **"Up"** and **"Down"** buttons, displaying arrow symbols for a clear and visually appealing navigation interface.
- **Responsive Design**: Ensures the gallery looks good on different screen sizes.

## Screenshot of Photo Gallery in Android Emulato

![Screenshot of Photo Gallery in Android Emulator](https://github.com/kbatya/PhotoGallery/blob/master/screenshotMAUI.png)

## Requirements

- **.NET MAUI**: Make sure you have the latest version of **.NET MAUI** installed.
- **Visual Studio**: You can use **Visual Studio** to develop and run the application.

## Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/kbatya/PhotoGallery.git



Requirements
.NET MAUI: Make sure you have the latest version of .NET MAUI installed.
Visual Studio: You can use Visual Studio to develop and run the application.
