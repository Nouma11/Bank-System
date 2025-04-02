# Bank System (C# Windows Forms)

## Overview
A simple banking system application built using **C#** and **Windows Forms**. This application allows users to manage their accounts, deposit and withdraw money, pay invoices, and view their profile information.

---

## Features

### 🔐 **User Authentication**
- Secure login with **username** and **password**.
- Lockout mechanism prevents brute-force attacks after multiple failed login attempts.

### 👤 **Profile Management**
- View and update **user profile information** (Name, Email, Phone, Balance).

### 💰 **Deposit & Withdrawal**
- **Deposit money** to your account.
- **Withdraw funds**, ensuring the balance is updated in real-time.

### 📑 **Invoice Payment**
- Pay **bills and invoices** securely by entering the invoice code.

### 📞 **Contact Support**
- Send messages to the **support team** for assistance.

---

## Project Structure
```
Bank-System/
├── Bank-System.sln       # Solution file
├── Bank-System/          # Main project folder
│   ├── Form1.cs          # Login form
│   ├── Form2.cs          # Main menu
│   ├── Profile.cs        # Profile management
│   ├── Deposit.cs        # Deposit functionality
│   ├── Withdraw.cs       # Withdrawal functionality
│   ├── Facture.cs        # Invoice payment
│   ├── Contact.cs        # Contact support
│   └── User.txt          # User database file
├── .gitignore            # Specifies files to ignore
└── README.md             # Project documentation (this file)
```

---

## 🔧 Usage

1️⃣ **Login**
- Enter your **username** and **password** to access the application.
- If you exceed the maximum number of failed login attempts, the system will **lock you out temporarily**.

2️⃣ **Main Menu**
- After logging in, navigate to different features such as **Profile, Deposit, Withdraw, Pay Invoice, and Contact Support**.

3️⃣ **Profile Management**
- View and update your personal details (**Name, Email, Phone, Balance**).

4️⃣ **Deposit / Withdraw**
- Add or remove funds from your account.
- The **balance updates in real-time**.

5️⃣ **Invoice Payment**
- Enter the invoice code to **pay bills securely**.

6️⃣ **Contact Support**
- Send a message to the **support team** for any assistance.

---

## 🚀 Future Improvements
- **Transaction History**: Keep track of all deposits, withdrawals, and payments.
- **Multi-user Support**: Add roles such as **Admin** and **Customer Support**.
- **Enhanced Security**: Implement **password hashing and encryption**.
- **Database Integration**: Replace the `User.txt` file with an actual **database** for better scalability.

---

## 🛠 Requirements
- **.NET Framework** (Version X.X or later)
- **Visual Studio** (for development)
- **Windows OS** (for running the application)

---

## 📜 License
This project is **open-source** and available under the **MIT License**.

Feel free to contribute and improve the application! 🚀

