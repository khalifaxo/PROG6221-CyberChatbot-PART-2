# Cybersecurity Awareness Chatbot

## Project Overview

The Cybersecurity Awareness Chatbot is a Windows Forms (WinForms) application developed in C# to educate users about cybersecurity best practices through an interactive conversation. The chatbot provides guidance on topics such as passwords, phishing scams, and online privacy while maintaining a user-friendly graphical interface.

This project was developed as part of Part 2 of the Cybersecurity Awareness Chatbot assignment and demonstrates the use of Object-Oriented Programming (OOP), collections, memory handling, sentiment detection, and GUI development.

---

## Features

### GUI Interface
- Developed using Windows Forms (WinForms).
- User-friendly layout with chat display, input field, and action buttons.
- Voice greeting support using a WAV file.
- Cybersecurity-themed interface design.

### Keyword Recognition
The chatbot recognises cybersecurity-related keywords such as:
- Password
- Privacy
- Scam
- Phishing

It provides relevant advice and cybersecurity awareness tips based on the detected keyword.

### Random Responses
- Uses collections such as Lists and Dictionaries.
- Provides varied responses for cybersecurity topics.
- Prevents repetitive chatbot responses.

### Conversation Flow
- Supports follow-up requests such as:
  - "Tell me more"
  - "Explain more"
  - "Give me another tip"
- Maintains context during conversations.

### Memory and Recall
The chatbot can remember:
- User name
- Favourite cybersecurity topic

This information is used later to personalise responses.

### Sentiment Detection
The chatbot detects simple emotions including:
- Worried
- Frustrated
- Curious

Responses are adjusted to provide support and encouragement when necessary.

### Error Handling
- Handles unknown inputs gracefully.
- Prevents application crashes caused by unexpected user input.
- Provides default responses when keywords are not recognised.

---

## Project Structure

```text
CyberChatbot
│
├── UI
│   ├── MainForm.cs
│   ├── MainForm.Designer.cs
│   └── MainForm.resx
│
├── Core
│   ├── ChatbotEngine.cs
│   ├── KeywordManager.cs
│   ├── MemoryManager.cs
│   ├── SentimentDetector.cs
│   └── RandomResponses.cs
│
├── Models
│   └── ChatMessage.cs
│
├── Data
│   └── ResponseData.cs
│
├── Assets
│   ├── greeting.wav
│   └── ascii.txt
│
├── Program.cs
└── README.md
```

---

## Technologies Used

- C#
- .NET Framework
- Windows Forms (WinForms)
- Visual Studio
- GitHub

---

## Object-Oriented Programming Concepts

This project demonstrates:
- Classes
- Objects
- Encapsulation
- Separation of concerns
- Modular design

---

## How to Run the Application

1. Open the project in Visual Studio.
2. Restore any required dependencies.
3. Build the solution.
4. Run the application using:
   - Start Debugging (F5)
   - Start Without Debugging (Ctrl + F5)

---

## Example Commands

### Password Advice

User:
```
Tell me about password safety
```

Bot:
```
Use strong, unique passwords that include letters, numbers, and symbols.
```

### Privacy Advice

User:
```
I'm interested in privacy
```

Bot:
```
Great! I'll remember that you're interested in privacy.
```

### Sentiment Detection

User:
```
I'm worried about online scams
```

Bot:
```
It's understandable to feel worried. Here are some tips to help you stay safe online.
```

---

## Future Improvements

- Database integration
- User account support
- More advanced sentiment analysis
- Speech recognition
- Additional cybersecurity topics

---

## Author

Student Name: RIYAAD KHALIFA
Student Number: ST10449569
Module: PROG6221
Institution: ROSEBANK COLLEGE INTERNATIONAL

---

## GitHub Repository

This repository contains:
- Source code
- Assets
- README documentation
- Commit history
- Release tags
