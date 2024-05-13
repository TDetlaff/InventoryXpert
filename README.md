# InventoryXpert

## Website

Link to our website: [InventoryXpert](http://inventoryxpert-001-site1.itempurl.com/)

Username: ***11172386***

Password: ***60-dayfreetrial***

## Overview

InventoryXpert is a comprehensive web-based inventory management system tailored to the needs of small to medium-sized businesses. Our platform empowers businesses to efficiently track their inventory, manage stock levels, streamline order fulfillment processes, and ensure seamless operations. With an intuitive user interface and robust features, InventoryXpert simplifies inventory management, enhances productivity, and drives business growth.

#### Key Features:

- **User-friendly Interface:** Intuitive navigation and data entry for enhanced user experience.
- **Inventory Tracking:** Real-time monitoring of inventory levels to prevent stockouts and overstocking.
- **Role-based Access Control:** Multi-user support with customizable access permissions for improved security.
- **Enhanced Security:**
  - **Two-Factor Authentication (2FA):** Implementation of two-factor authentication adds an extra layer of security to user accounts, mitigating the risk of unauthorized access.
  - **QR Code Generation for TOTP Authenticator Apps:** Secure QR code generation allows users to set up two-factor authentication quickly and securely using authenticator apps like Google Authenticator or Authy.
  - **Security Stamp Validation Intervals:** Regular security stamp validation intervals mitigate security threats like session fixation attacks, ensuring the continued security of user sessions.
  - **Global Fallback Authorization Policy:** Enforced authorization policy requires all users to be authenticated before accessing any part of the website, enhancing overall application security.
  - **Cookie-Based Authentication Settings:** Configured cookie-based authentication settings optimize security and usability, including cookie names, paths for login and access denied pages, expiration timespan, and sliding expiration.

By integrating these enhanced security features, InventoryXpert not only simplifies inventory management but also prioritizes the security of user data and access control, providing a comprehensive solution for businesses seeking to streamline operations while ensuring robust security measures.

#### Target Audience:  
InventoryXpert is ideal for small to medium-sized businesses across various industries, including retail, e-commerce, manufacturing, and distribution. It caters to companies looking to automate their inventory management processes and improve overall efficiency.

## Installation

#### Prerequisites:

Before installing InventoryXpert, ensure that your system meets the following prerequisites:

1. **Operating System:** Compatible with Windows, macOS, or Linux.
2. **.NET SDK:** Installed .NET SDK version 6.0 or later.
3. **Database Server:** SQL Server or SQLite database server installed and configured.
4. **Web Server:** A web server like IIS (Internet Information Services) or Apache installed and configured (if hosting the application on a server).

#### Installation Steps:

Once you've verified that your system meets the prerequisites, follow these steps to install InventoryXpert:

1. **Download Source Code:** Clone or download the source code of InventoryXpert from the repository.
   
2. **Configure Database:** Open the project in your preferred IDE (Integrated Development Environment) such as Visual Studio or Visual Studio Code. Navigate to the ``appsettings.json`` file and configure the connection string to point to your SQL Server or SQLite database.
   
3. **Restore Dependencies:** Open a terminal or command prompt, navigate to the project directory, and run the following command to restore the NuGet packages and dependencies required for the project:
``dotnet restore``

4. **Build Solution:** Run the following command in the terminal to build the solution, compile the project, and resolve any build-time errors:
``dotnet build``

5. **Run Migrations:** If you're using Entity Framework Core for database migrations, apply any pending migrations to update the database schema by running the following command:
``dotnet ef database update``

6. **Run Application:** Start the application by running the following command in the terminal:
``dotnet run``

7. **Access Application:** Once the application is running, open a web browser and navigate to the specified URL (usually ``https://localhost:5001`` or ``https://localhost:44320``).

8. **Set Up Initial Admin User:** Follow the on-screen instructions to set up an initial admin user account. This step may vary depending on the application's setup process

9. **Login and Configure:** Log in with the admin user credentials and configure any additional settings or features as needed.

That's it! You've now successfully installed InventoryXpert and can start using it to manage your inventory.

## Usage

1. **Register an Account:** To get started with InventoryXpert, you need to register an account. Follow these steps to create your account and gain access to the platform.

    - Open the web browser and navigate to the registration page using the provided URL.
    - Fill out the registration form with your email address and desired password.
    - Click the "Register" button to create your account.
3. **Login to Your Account:** Once you've registered, you can log in to your account to access the InventoryXpert dashboard. Follow these steps to log in.
    - After registering, return to the login page.
    - Enter your email address and password.
    - Click the "Log in" button to access your account dashboard.
5. **Explore Dashboard:** Upon logging in, you'll be directed to the dashboard, where you can manage your inventory and perform various tasks. Here's how to navigate through the dashboard sections.
    - Once logged in, you'll be directed to the dashboard.
    - Navigate through the different sections such as orders, items, categories, and suppliers to manage your data.
    - Use the top bar or navigation menu to switch between different sections.
7. **Manage Inventory:** Inventory management is a core feature of InventoryXpert. Follow these steps to add, update, or remove items from your inventory.
    - Add new items to your inventory by navigating to the "Items" section and clicking the "Create New" button.
    - Update existing items by selecting them from the inventory list and making changes as needed.
    - Remove items by selecting the delete option next to the item.
9. **Track Orders:** Keeping track of orders is essential for efficient business operations. Follow these steps to view existing orders and create new ones.
    - View existing orders and their statuses in the orders section.
    - Create new orders by clicking the "Create Order" button and filling out the order details.
11. **Manage Categories and Suppliers:** Organizing your inventory into categories and managing supplier information can streamline your operations. Follow these steps to manage categories and suppliers.
    - Create, update, or delete categories and suppliers as necessary to organize your inventory.
13. **Logout:** Once you've completed your tasks, it's important to log out of your account to maintain security. Here's how to log out of InventoryXpert.
    - When finished, click the "Logout" button to securely log out of your account.

## Contributors

- Thomas Hassemer - Team Leader
- Taylor Detlaff - Quality Assurance
- Ben Connell - Secretary
