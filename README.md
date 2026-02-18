# NorthwindSurfer - SQL Server & Dapper CRUD System

Ushbu loyiha mashhur **Northwind** ma'lumotlar bazasi ustida asosiy CRUD (Create, Read, Update, Delete) amallarini bajarishni ko'rsatib beruvchi konsol ilovasi hisoblanadi. Loyihada ma'lumotlar bazasi bilan ishlash uchun tezkor va samarali **Dapper ORM** kutubxonasidan foydalanilgan.

## 🚀 Imkoniyatlar

Dastur quyidagi 4 ta asosiy jadval bilan to'liq ishlay oladi:
* **Customers** (Mijozlar)
* **Orders** (Buyurtmalar)
* **Order Details** (Buyurtma tafsilotlari)
* **Products** (Mahsulotlar)

### Funksional bo'limlar:
1.  **Create**: Jadvallarga yangi ma'lumotlar qo'shish.
2.  **Read**: 
    * Barcha ma'lumotlarni ro'yxat ko'rinishida chiqarish.
    * ID bo'yicha qidirish.
    * Nomi (Name) bo'yicha qidirish.
3.  **Update**: Mavjud ma'lumotlarni yangilash.
4.  **Delete**: Ma'lumotlarni bazadan o'chirish.

## 🛠 Texnologiyalar
* **Til:** C# (.NET 6/7/8)
* **ORM:** Dapper
* **Baza:** Microsoft SQL Server
* **Drayver:** Microsoft.Data.SqlClient

## 📁 Loyiha Tuzilmasi
```text
NorthwindSurfer/
├── Data/
│   └── DbContext.cs          # Baza bilan aloqa o'rnatuvchi klass
├── Models/
│   ├── Customers.cs          # Mijozlar modeli
│   ├── Orders.cs             # Buyurtmalar modeli
│   ├── OrderDetail.cs        # Buyurtma detallari modeli
│   └── Products.cs           # Mahsulotlar modeli
├── Services/
│   ├── CustomersServices.cs  # Mijozlar uchun mantiq
│   ├── OrdersServices.cs     # Buyurtmalar uchun mantiq
│   ├── OrderDetailServices.cs# Tafsilotlar uchun mantiq
│   └── ProductsServices.cs   # Mahsulotlar uchun mantiq
└── Program.cs                # Dasturning asosiy kirish nuqtasi
