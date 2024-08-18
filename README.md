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
## Scatch of the Registration Page
![Scatch of the Screen](https://github.com/kbatya/PhotoGallery/blob/master/registrationScatch.png)
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


## Screenshot in Android Emulator
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

## Screenshot of Photo Gallery in Android Emulator

![Screenshot of Photo Gallery in Android Emulator](https://github.com/kbatya/PhotoGallery/blob/master/screenshotMAUI.png)



# Login Page with MVVM Pattern

## Table of Contents
1. [Overview](#overview)
2. [Screen Design](#screen-design)
3. [Implementation details](#implementation-details)
  1)  [ViewModel](#view-model)
  2)  [View] (#view)
  3)  [BaseView] (#base-view)
  4)  [Functionality] (#functionality)
  5)  [Screen] (#screen)
  6)  
6. [Requirements](#requirements)
7. [How to Run](#how-to-run)
## Scatch of the Registration Page
![Scatch of the Screen](https://github.com/kbatya/PhotoGallery/blob/master/registrationScatch.png)
## Screen Design
The login screen includes the following elements:
- Image element 
- Input fields for:
  - Username
  - Password
- Password visibility toggle
- Label for error message
- Login button
- Cancel button

## Implementation Details

## ViewModel: LoginViewModel.cs

Manages the logic and data for the login process
Implements property change notifications
Contains commands for login, cancel, and password visibility toggle


## View: LoginPage.xaml and LoginPage.xaml.cs

Defines the UI layout using XAML
Binds UI elements to the ViewModel properties and commands


## Base ViewModel: ViewModelBase.cs

Provides a base implementation of INotifyPropertyChanged



## Functionality

-The Login button is enabled only when both username and password fields are filled
-The Cancel button is enabled when at least one field contains a value
-Clicking Login validates the credentials (currently set to "admin" / "1234")
-Successful login displays a green "Access is granted" message
-Failed login attempts show a red error message
-The Cancel button clears all fields and error messages

      .

## Screen Implementation
The screen named `LoginPage`.


## Screenshot in Android Emulator
![Screenshot of the Android Emulator](https://github.com/kbatya/PhotoGallery/blob/master/screenshotLogin.png)


- **.NET MAUI**: Make sure you have the latest version of **.NET MAUI** installed.
- **Visual Studio**: You can use **Visual Studio** to develop and run the application.

## Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/kbatya/PhotoGallery.git



Requirements
.NET MAUI: Make sure you have the latest version of .NET MAUI installed.
Visual Studio: You can use Visual Studio to develop and run the application.
