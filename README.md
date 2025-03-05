![1](https://github.com/user-attachments/assets/37effd43-281f-4726-b4f3-917f6e6db2e7)# CitizenHelper

CitizenHelper is a Windows Presentation Foundation (WPF) C# application designed to provide South African citizens access to municipal services and information about local events and announcements. The application offers features such as reporting issues, requesting status updates, event searches based on categories and dates, personalized recommendations, and multilingual support to enhance user experience.

## Table of Contents
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Running the Application](#running-the-application)
- [Usage](#usage)

## Features
- **Local Events and Announcements:** Browse and search for local events and announcements in an aesthetic interface.
- **Report Issues:** Users can report issues to municipal services with location, category, description, and file attachment.
- **Request Status:** Get feedback and status updates on reported issues.
- **Search Functionality:** Filter events based on categories and dates using an efficient search mechanism.
- **Personalized Recommendations:** Receive event recommendations based on your search patterns and preferences.
- **Multilingual Support:** Switch between multiple languages to navigate the application in your preferred language.
- **Data Persistence:** Events and user data are stored locally without the need for external databases or software.

## Screens
![1](https://github.com/user-attachments/assets/7ddc6e24-f751-4073-a73b-d0994422fbe0)
![2](https://github.com/user-attachments/assets/e9f7e0ef-2f8e-487e-90fe-0735fd3d6607)
![3](https://github.com/user-attachments/assets/7600795e-0a8d-4de8-b991-8af03042d8c2)
![4](https://github.com/user-attachments/assets/aa162726-acee-4274-b87c-1ecc2c3093c1)


## Prerequisites
Before you begin, ensure you have met the following requirements:
- **Operating System:** Windows 10 or later.
- **Development Environment:** Visual Studio (2019 or later recommended).
- **.NET Framework:** .NET Framework 4.7.2 or later.

## Installation
Follow these steps to install and set up the CitizenHelper application on your local machine:

1. **Download the Project**
   - Option 1: Clone the repository using Git.
     ```bash
     git clone "link to repo"
     ```
   - Option 2: Download the ZIP file of the project.
     - Click on the "Code" button on the repository page.
     - Select "Download ZIP".
     - Save the ZIP file to your preferred location.

2. **Extract the Project Files**
   If you downloaded the ZIP file:
   - Right-click on the downloaded ZIP file.
   - Select "Extract All".
   - Choose a destination folder on your local device and extract the contents.

3. **Open the Project in Visual Studio**
   1. Launch Visual Studio.
   2. Click on **File > Open > Project/Solution**.
   3. Navigate to the extracted project folder.
   4. Select the `citizenHelper.sln` file to open the project solution in Visual Studio.

## Running the Application
After successfully building the project, follow these steps to run the CitizenHelper application:

1. **Start the Application:**
   - In Visual Studio, press `F5` or click the **Start** button to run the application in Debug mode.
   - Alternatively, go to **Debug > Start Debugging**.

2. **Application Startup:**
   - The application will launch and display the Main Menu window.
   - From here, you can navigate to different sections of the application.

## Usage

### Navigating the Main Menu

- **Language Selection:**
  - Located at the top-left corner of the Main Menu.
  - Select your preferred language from the dropdown to change the application's language dynamically.

- **List of Reports:**
  - View existing reports and their details.
  - Scroll through the list using the scroll bar.

- **Report an Issue:**
  - Click on the **Report an Issue** section to open a new window where you can submit a report.
  - After submitting, the report will appear in the List of Reports.

- **Announcements & Events:**
  - Click on the **Announcements & Events** section to open the Local Events and Announcements window.
  - Browse, search, and view events based on categories and dates.
  - View personalized recommendations based on your search history.

- **Request Status:**
  - Click on the **Request Status** section to check the status of your submitted reports or requests.
  - Use the unique request ID to search for a specific report logged.
