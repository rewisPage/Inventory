# Laboratory Exercise: Manually Throwing Custom Exceptions (Inventory App)

A Windows Forms application written in C# (.NET Framework) created as part of the IT1811 course curriculum. The application demonstrates object-oriented design, Windows Forms data binding using `BindingSource` and `DataGridView`, and regular-expression input validation paired with manually thrown custom exception handling.

<img width="846" height="474" alt="image" src="https://github.com/user-attachments/assets/85c850f9-ffae-4864-b0bb-7acd941b1ed1" />


---

## 📌 Objectives

* Design and build a Windows Forms UI for inventory item creation.
* Encapsulate product information using a structured C# model class (`ProductClass`).
* Create custom exception types inheriting from the base `System.Exception` class.
* Perform regular-expression string validation and manually throw custom exceptions when input formats are violated.
* Handle runtime exceptions using `try-catch` structures without relying on standard uncaught exceptions.

---

## 🛠️ Software & Tools Required

* **Operating System:** Windows 10 / 11
* **IDE:** Visual Studio 2015 or higher (with the *.NET desktop development* workload enabled)
* **Framework:** .NET Framework (4.7.2 or higher recommended)
* **Language:** C#

---

## 📂 Project Architecture

```
Inventory/
├── CustomExceptions.cs      # Custom exception definitions
├── ProductClass.cs          # Model class encapsulating inventory item properties
├── frmAddProduct.cs         # Form backend logic, input regex checks, and event handlers
├── frmAddProduct.Designer.cs# Auto-generated Windows Forms designer layout
├── Program.cs               # Application entry point
└── README.md                # Project documentation
```

---

## 🧩 Key Components

### 1. Model Class (`ProductClass`)
Encapsulates all item fields with corresponding public get/set properties:
* `productName` (string)
* `category` (string)
* `manufacturingDate` (string)
* `expirationDate` (string)
* `description` (string)
* `quantity` (int)
* `sellingPrice` (double)

### 2. Custom Exception Classes
Defined under `CustomExceptions.cs` to satisfy the challenge exercises:
* `StringFormatException`: Thrown when textual inputs fail validation (e.g., non-alphabetic product names).
* `NumberFormatException`: Thrown when integer inputs contain invalid characters or formats.
* `CurrencyFormatException`: Thrown when price inputs do not follow standard numerical/decimal format.

### 3. Regular Expression Input Validation
Input validation routines extract and sanitize form data:
* **Product Name:** `^[a-zA-Z\s]+$` — ensures only letters and spacing are supplied.
* **Quantity:** `^[0-9]+$` — ensures strictly positive whole integer values.
* **Selling Price:** `^(\d+(\.\d{1,2})?)$` — validates standard monetary numeric formats.

---

## 🚀 Getting Started

### Prerequisites
Make sure you have Visual Studio installed with the **.NET desktop development** workload.

### Clone the Repository
```bash
git clone https://github.com/<your-username>/<your-repo-name>.git
cd <your-repo-name>
```

### Running the Project
1. Open the `.sln` (Solution) file inside Visual Studio.
2. Restore NuGet packages and verify build targets if prompted.
3. Build the solution using `Ctrl + Shift + B`.
4. Press `F5` or click **Start** to run the application.

---

## 📋 Features & Controls

| Control Name | Control Type | Purpose |
| :--- | :--- | :--- |
| `txtProductName` | TextBox | Input field for item name |
| `cbCategory` | ComboBox | Dropdown selection populated on `Form_Load` |
| `dtPickerMfgDate` | DateTimePicker | Picker for manufacturing date |
| `dtPickerExpDate` | DateTimePicker | Picker for expiration date |
| `txtQuantity` | TextBox | Input field for quantity count |
| `txtSellPrice` | TextBox | Input field for unit selling price |
| `richTxtDescription` | RichTextBox | Free-text field for item details |
| `btnAddProduct` | Button | Triggers validation, instantiates `ProductClass`, and binds to grid |
| `gridViewProductList` | DataGridView | Displays the dynamically updated product list |

---

## 🧪 Evaluation Rubric

| Criteria | Performance Indicators | Points |
| :--- | :--- | :---: |
| **Correctness** | The program correctly catches exceptions and populates the grid | 30 |
| **Logic** | Code accurately follows regex checks and architectural requirements | 30 |
| **Efficiency** | Concise and clean separation of concerns without code bloat | 20 |
| **Syntax** | Follows clean C# idioms and standard conventions | 20 |
| **Total** | | **100** |

---

## 📄 License
This project is completed as an academic laboratory exercise for educational purposes.
