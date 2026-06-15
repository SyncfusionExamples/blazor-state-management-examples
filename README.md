# Blazor State Management Examples

This repository contains practical, real-world examples demonstrating different state management techniques in Blazor.

It is designed as a companion to the blog:
**"State Management in Blazor: A Complete Guide"**

Each example focuses on a specific pattern and is organized into separate folders for easy understanding and direct usage.

---

## 🚀 What You’ll Learn

This repo helps you understand how to choose the right state approach based on:

- Component hierarchy
- Hosting model (Server / WebAssembly / Web App)
- Data lifetime
- Performance considerations
- Scalability needs

---

## 📂 Project Structure

Each folder maps directly to a concept explained in the blog:

```text
/src
│
├── global-state-with-di-services/
├── local-component-state/
├── parent-child-communication/
├── prerendered-state-persistence/
├── sharing-state-down-the-tree/
└── url-query-string-parameters/

```
---

## 📘 Examples Overview

### 1️⃣ URL/Query String Parameters
- Making state bookmarkable and shareable.

📁 Folder: `url-query-string-parameters`

---

### 2️⃣ Local Component State
- Simple UI-only state confined to a single component.

📁 Folder: `local-component-state`

---

### 3️⃣ Parent-Child Communication
- Passing data and events between related components.

📁 Folder: `parent-child-communication`

---

### 4️⃣ Sharing State Down the Tree: Cascading Parameters and Values
- Sharing data across deep component trees without prop drilling.

📁 Folder: `sharing-state-down-the-tree`

---

### 5️⃣ Global State with Dependency Injection Services  
- Sharing state across unrelated components and pages.

📁 Folder: `global-state-with-di-services`

---

### 6️⃣ Prerendered State Persistence 
- Maintaining state during SSR → interactive transitions.

📁 Folder: `prerendered-state-persistence`

---

## 🧠 How to Use This Repo

1. Clone the repository:
   ```bash
   git clone https://github.com/SyncfusionExamples/blazor-state-management-examples.git
2. Open in Visual Studio / VS Code.
3. Navigate to each example via routes.

### ⚙️ Hosting Model Notes
This repo includes examples targeting:

- Blazor Server
- Blazor WebAssembly
- Blazor Web App (Interactive SSR)

Some examples are specific to certain hosting models:

- Protected Browser Storage → Server only
- Prerender Persistence → Web App / Server
- Singleton vs Scoped behavior varies by hosting model

---

## 📄 License and Copyright

> This is a commercial product and requires a paid license for possession or use. Syncfusion® licensed software, including this component, is subject to the terms and conditions of Syncfusion®. To acquire a license, visit https://www.syncfusion.com/account/downloads.

Are you already a Syncfusion user? You can download the product setup [here](https://www.syncfusion.com/account/downloads). If you're not yet a Syncfusion user, you can download a [30-day free trial](https://www.syncfusion.com/downloads).

---

## 📞 Support

For technical support and questions:
- [Syncfusion Support Portal](https://support.syncfusion.com/support/tickets/create)
- [Documentation](https://help.syncfusion.com/)
- [Community Forums](https://www.syncfusion.com/forums)

---