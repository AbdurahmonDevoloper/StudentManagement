# StudentManagement CRUD System

StudentManagement - bu C# dasturlash tili va .NET platformasida yaratilgan konsol korporativ tizimi bo'lib, o'qituvchilar va talabalar ma'lumotlarini samarali boshqarish (CRUD amallari) uchun mo'ljallangan.

---

## Loyiha Logotipi

<p align="center">
  <img src="images/logo.png" alt="StudentManagement Logo" width="200px">
</p>

*(Eslatma: Loyihangiz logotipini ko'rsatish uchun loyiha ildiz papkasida `images` degan papka ochib, uning ichiga `logo.png` rasmini joylashtiring)*

---

## Loyihaning Ishlash Jarayoni

Dasturning konsol muhitida ishlash jarayoni va menyular ko'rinishi:

<p align="center">
  <img src="images/application_demo.png" alt="<img width="861" height="654" alt="Km hisoblaydi" src="https://github.com/user-attachments/assets/39ec8356-ca3b-4564-9435-9bd43e38a1eb" />
" width="600px">
</p>

*(Eslatma: Dastur ishlayotgan vaqtdagi skrinshotni `images` papkasiga `application_demo.png` nomi bilan joylashtiring)*

---

## Loyiha Tarkibi (Strukturasi)

Loyiha ob'ektga yo'naltirilgan dasturlash (OOP) tamoyillari asosida alohida fayllarga ajratilgan:

* **Modellar (Data Models):**
    * `Teacher.cs` — O'qituvchi ma'lumotlar strukturasi (Id, Name, Subject).
    * `Student.cs` — Talaba ma'lumotlar strukturasi (Id, Name, Age, TeacherId).
* **Mantiqiy Qism (Managers/Services):**
    * `TeacherManager.cs` — O'qituvchilar ustida Create, Read, Update, Delete amallari.
    * `StudentManager.cs` — Talabalar ustida Create, Read, Update, Delete amallari.
* **Asosiy Oynasi:**
    * `Program.cs` — Foydalanuvchi interfeysi va konsol menyusi boshqaruvi.

---

## Texnologik Paket

* **Dasturlash tili:** C# 8.0 yoki undan yuqori
* **Platforma:** .NET Core / .NET SDK
* **Ma'lumotlarni saqlash:** Runtime Memory (List<T> kolleksiyalari)

---

## Loyihani Ishga Tushirish

Loyihani o'zingizning kompyuteringizda ishga tushirish uchun quyidagi buyruqlarni ketma-ket bajaring:

1. Repozitoriyani yuklab oling:
   ```bash
   git clone [https://github.com/foydalanuvchi_nomi/repo_nomi.git](https://github.com/foydalanuvchi_nomi/repo_nomi.git)
