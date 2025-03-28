# 🛒 Product API - ASP.NET Core

This is a simple **CRUD API for managing products** built with **ASP.NET Core 7** and **Entity Framework Core** (EF Core).

## 🚀 Features

- ✅ Create, Read, Update, and Delete (CRUD) operations for products.
- ✅ Uses **Entity Framework Core** with **Code-First Migrations**.
- ✅ **Swagger UI** for API documentation.
- ✅ **SQL Server** as the database.

---

## 📦 Installation

### **1️⃣ Clone the Repository**

```sh
git clone https://github.com/elhussein-salah/ProductApi
cd ProductApi
```

### **2️⃣ Install Dependencies**

Make sure you have the .NET SDK installed, then run:

```sh
dotnet restore
```

### **3️⃣ Update Database (Code-First Migrations)**

```sh
dotnet ef database update
```

### **4️⃣ Run the Application**

```sh
dotnet run
```

✅ The API will start on **`http://localhost:5000`**.

---

## 🔥 API Endpoints

### **📌 Get All Products**

```http
GET /api/products
```

#### ✅ Response:

```json
[
  {
    "id": 1,
    "name": "Laptop",
    "price": 1200.99
  }
]
```

### **📌 Get Product by ID**

```http
GET /api/products/{id}
```

### **📌 Create a New Product**

```http
POST /api/products
Content-Type: application/json
```

#### ✅ Request Body:

```json
{
  "name": "Smartphone",
  "price": 799.99
}
```

### **📌 Update a Product**

```http
PUT /api/products/{id}
Content-Type: application/json
```

#### ✅ Request Body:

```json
{
  "name": "Updated Laptop",
  "price": 1500
}
```

### **📌 Delete a Product**

```http
DELETE /api/products/{id}
```

---

## 🛠 Technologies Used

- **.NET Core 8**
- **Entity Framework Core**
- **SQL Server**
- **Swagger (Swashbuckle)**
- **C#**
- **ASP.NET Core Web API**

---

## 📜 License

This project is licensed under the **MIT License**.  
Feel free to use, modify, and distribute it.

---

## 🤝 Contributing

1. Fork the repository
2. Create a new branch (`git checkout -b feature-branch`)
3. Commit your changes (`git commit -m "Added new feature"`)
4. Push to the branch (`git push origin feature-branch`)
5. Open a **Pull Request**

---

## 📬 Contact

For any questions, feel free to contact me:

- 📧 Email: `your-email@example.com`
- 🔗 GitHub: [elhussein-salah](https://github.com/elhussein-salah)
---
