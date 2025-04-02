Bank System
C#
Windows Forms

A simple banking system application built using C# and Windows Forms. This application allows users to manage their accounts, deposit and withdraw money, pay invoices, and view their profile information.

Features
User Authentication : Secure login with username and password.
Profile Management : View and update user profile information (name, email, phone, balance).
Deposit and Withdrawal : Add or remove funds from the user's account.
Invoice Payment : Pay bills and invoices securely.
Contact Support : Send messages to the support team.
Lockout Mechanism : Prevents brute-force attacks after multiple failed login attempts.

Bank-System/
├── Bank-System.sln          # Solution file
├── Bank-System/             # Main project folder
│   ├── Form1.cs             # Login form
│   ├── Form2.cs             # Main menu
│   ├── Profile.cs           # Profile management
│   ├── Deposit.cs           # Deposit functionality
│   ├── Withdraw.cs          # Withdrawal functionality
│   ├── Facture.cs           # Invoice payment
│   ├── Contact.cs           # Contact support
│   └── User.txt             # User database file
├── .gitignore               # Specifies files to ignore
└── README.md                # This file

Usage
Login :
Enter your username and password to access the application.
If you exceed the maximum number of failed login attempts, the system will lock you out temporarily.
Main Menu :
After logging in, you can navigate to different features such as Profile, Deposit, Withdraw, Pay Invoice, and Contact Support.
Profile :
View and update your personal information and check your account balance.
Deposit/Withdraw :
Add or remove funds from your account. The balance is updated in real-time.
Pay Invoice :
Pay bills or invoices securely by entering the invoice code.
Contact Support :
Send a message to the support team for assistance.
