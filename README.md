# Trello Automation Script

## Description
This Selenium WebDriver script automates functional testing of Trello’s web application for the Deepchain Labs QA Internship assignment. It validates two core features: creating a new board (Test Case TC-001) and adding a card to a list (Test Case TC-004).

## Test Cases Covered
- **TC-001: Create a new board**
  - **Scenario**: Create a new board with a specified name.
  - **Expected Result**: Board is created and appears on the dashboard within 2 seconds.
- **TC-004: Add a new card to a list**
  - **Scenario**: Add a new card with a title to an existing list.
  - **Expected Result**: Card is added to the list and visible within 1 second.

## Prerequisites
- Node.js (v16 or higher): [nodejs.org](https://nodejs.org)
- Google Chrome (latest version)
- ChromeDriver: Match Chrome version ([chromedriver.chromium.org](https://chromedriver.chromium.org))
- Trello account with valid credentials

## Setup Instructions
1. Create project directory:
   ```bash
   mkdir trello-automation
   cd trello-automation
