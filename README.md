# Seller Bazaar

## Overview

I am delighted to share my second-semester project—a sophisticated C# Winforms and SQL Server-based application. It is a *One-Stop Ecommerce Shopping Application* where sellers, buyers, and admin can select their role and login to start selling, buying, or managing the app respectively. This project serves as a testament to my proficiency in Object-Oriented Programming and database management, showcasing my capacity to design and implement comprehensive software solutions.

## Features

- ### Prompting The User to Select Role and Login:

  The moment the user starts the application, they are prompted to select their role in this application.
  
  - If they are a buyer, they select "**Buyer**" and login using their credentials that are already saved in the SQL Server as shown in the GIF.
  ![Login GIF](https://drive.google.com/file/d/11pFVi9K5aucIt138QpZBd3IAWgZgtf3z/view?usp=drive_link)

- ### Don't Have an Account?

  If the user is using the application for the first time, they can Sign-Up and make a new account that will be saved in the SQL Server. Once the account is made, it can be used to Sign-In and start using the app.
  ![Don't Have an Account?](GIFs%20and%20ScreenShots/Don't%20Have%20an%20Account.gif)

- ### Features for Sellers

  The seller has Two Sections in the app:
  
  - My Products Section: In this section, the seller can View, Add, Update, and Delete all of their listed Products. Any changes made in the app will reflect in the SQL Server in the Products Table. The Products can also be filtered using Product Categories Filter.
  
  - Sales Section: Here, the seller can keep track of all the sales they have made while also being able to filter them using the Date and Time of when the Sale was made.
    
  ![Seller Features](GIFs%20and%20ScreenShots/Seller%20Features.gif)

- ### Features For Buyers

  The buyer has 3 Sections in the app:

  - Available Products: The buyers can view all the products listed by an unlimited number of sellers in the 'Available Products' Section. The products listed here can be filtered using the Product Category Filter available in the app.
    
  - My Cart: If the buyer wishes to buy a product, they select the product and add it to the cart, The price of the product will be updated in the Total bill box in real-time. The Products from the Cart can also be filtered and removed using Product Filter. Any product added or removed will be visible in the SQL Server.
 
  - Purchase History: Upon Confirming A Purchase, The product, along with its price and Quantity will be added to the purchase history. If the user wishes to find a particular Purchase they made, they can filter all the products using The Date Filter available in the section.
 
  ![Buyer Features](GIFs%20and%20ScreenShots/Buyer%20Features.gif)

- ### Features For Admin

    The admin has 3 Sections in the app:

    - View All Sellers: This allows the admin to view a list of all the sellers that are actively using the app. Here, The admin has the authority to Ban and UnBan any Seller due to complaints or other reasons.

    - #### If A Seller is Banned

         If a seller is Banned, as shown in the GIF below.
         - Their Account Status is changed to 0 in the SQL Server.
         - The seller can't login and use their Account.
         - The buyers are not able to view the Banned Seller's Products.

    ![Banned Seller](GIFs%20and%20ScreenShots/Seller%20Banned.gif)

    - View All Buyers: Just like the previous Tab. Here, The admin has the authority to Ban and UnBan any Buyer due to complaints or other reasons.

    - #### If A Buyer is Banned

         If a Buyer is Banned, as shown in the GIF below.
         - Their Account Status is changed to 0 in the SQL Server.
         - The Buyer can't login and use their Account.

    ![Banned Buyer](GIFs%20and%20ScreenShots/Buyer%20Banned.gif)

    - Total Sales: Using this Tab, The admin can keep track of how the app is performing and also keep track of the total number of purchases and sales being made by the buyers and the sellers respectively.

## Invalid Entries

- ### Invalid Sign-Up

    When Signing-Up and creating a new account, The User is required to have a unique Username. If The User accidentally tries to make an account using a username that is already present in the Database, they are given an error warning indicating them to use a different username.

    ![Invalid Sign-Up](GIFs%20and%20ScreenShots/Invalid%20Username.gif)

- ### Invalid Sign-In

    If, While Signing-Into the app, The user enters incorrect credentials, they will be given an error indicating to use correct credentials and Try again.

    ![Invalid Sign-In](GIFs%20and%20ScreenShots/Invalid%20Password.gif)

## Want To Set Up and Run This App?

- ### Prequisites

  - Visual Studio 2022
  - SQL Server Management Studio
  - .NET Framework in VS

- ### Installation

  1. Clone The repository:
  ```git clone https://github.com/itsAbdullahMaqsood/SellerBazaar-CSharp.git```

  2. Open the project in Visual Studio.

  3. Modify the database connection string in app.config to point to your SQL Server instance:
  ```<connectionStrings>
  <add name="MyDbConnection" connectionString="Data Source=your-server;Initial Catalog=your-database;User Id=your-username;Password=your-password;" providerName="System.Data.SqlClient" />
</connectionStrings>```

  4. Build and run the application.
