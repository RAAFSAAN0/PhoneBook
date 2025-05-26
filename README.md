# Trello Selenium Automation Script – Deepchain Labs QA Internship

This repository contains a basic Selenium automation script written in JavaScript to test core features of the Trello platform. This is a submission for **Round 1: Technical Test** of the Deepchain Labs QA Internship.

---

## ✅ What the Test Is Doing

The script performs the following actions step-by-step:

1. Opens Trello login page.
2. Logs in using predefined credentials.
3. Creates a new board titled `Automated Board <timestamp>`.
4. Adds a list named **"To Do"** to the board.
5. Adds a card titled **"Write Blog Post"** under that list.
6. Leaves the browser open for visual confirmation (manual verification).

---

## 📦 How to Install Dependencies

### 1. Prerequisites

- **Node.js** (v16+)
- **Google Chrome** (latest version)
- **ChromeDriver** installed and added to system PATH

### 2. Installation Steps

```bash
# Create project folder
mkdir selenium-test
cd selenium-test

# Initialize npm project
npm init -y

# Install Selenium WebDriver
npm install selenium-webdriver
