# 🎓 Student Management System (Console App)

**Student Management System** — bu C# tilida yozilgan **konsol ilova** bo‘lib, talabalarni xotirada (in-memory) boshqarish uchun mo‘ljallangan. Dastur orqali talabalarni qo‘shish, ko‘rish va mavjud limitni nazorat qilish mumkin. Ilova oddiy **login (parol)** mexanizmi bilan himoyalangan.

---

## 🚀 Loyihaning imkoniyatlari (Features)

- 🔐 Parol orqali tizimga kirish (3 ta urinish limiti)
- ➕ Talaba qo‘shish (ism, familiya)
- 👀 Barcha talabalarni ko‘rish
- 📊 Talabalar uchun mavjud bo‘sh o‘rinlarni ko‘rsatish
- 🧠 In-memory ma’lumotlar bazasi (`DbContext`)
- 🧩 Layered architecture (Domain, Infrastructure, Application, Client)

---

## 🛠 Ishlatilgan texnologiyalar

- **C#**
- **.NET Console Application**
- **OOP (Object-Oriented Programming)**
- In-memory data storage (array asosida)

---

## 📁 Loyiha strukturasi

Management
│
├── ManagementDomain
│ └── Models
│ └── Student.cs
│
├── Management.Infrastructure
│ └── Data
│ └── DbContext.cs
│
├── Management.Application
│ └── Services
│ └── StudentService.cs
│
└── Managment.Client
└── Program.cs

yaml
Copy code

---

## 🧠 Arxitektura tushuntirishi

### 🔹 Domain
- `Student` — talaba modeli (Id, FirstName, LastName)

### 🔹 Infrastructure
- `DbContext` — talabalarni **array** ko‘rinishida saqlovchi in-memory kontekst  
- Maksimal sig‘im: **12 ta talaba**

### 🔹 Application
- `StudentService` — talabalar bilan ishlash logikasi:
  - Talaba qo‘shish
  - Talabalarni olish
  - Limitni tekshirish

### 🔹 Client
- `Program.cs` — foydalanuvchi bilan ishlovchi qism:
  - Login
  - Menu
  - Konsol orqali CRUD amallari

---

## 🔐 Login ma’lumotlari

```text
Parol: admin123
Maksimal urinishlar soni: 3 ta

Noto‘g‘ri parol kiritilsa, dastur yopiladi

▶️ Dasturni ishga tushirish
Repository’ni clone qiling:

bash
Copy code
git clone https://github.com/Tohirbek2101/Management.git
Visual Studio’da oching

Managment.Client loyihasini Startup Project qilib tanlang

Dasturni ishga tushiring (Ctrl + F5)

📌 Konsol menyusi
text
Copy code
1. Talaba qo'shish
2. Talabalarni ko'rish
3. Qabul soni
0. Chiqish
⚠️ Cheklovlar
Ma’lumotlar faqat dastur ishlayotgan paytda saqlanadi

Dastur yopilgach, barcha talabalar o‘chib ketadi

Maksimal talaba soni: 12 ta

📈 Kelajakdagi rivojlantirish g‘oyalari
📂 Faylga yoki database’ga saqlash

✏️ Talabani o‘chirish / tahrirlash

🔎 Qidiruv funksiyasi

🧪 Unit testlar qo‘shish

🌐 GUI yoki Web API versiyasi

👤 Muallif
Tohirbek

GitHub: Tohirbek2101
