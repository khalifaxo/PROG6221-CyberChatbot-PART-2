Cybersecurity Awareness Chatbot – Part 3
Project Overview

This project is a Windows Forms C# application developed as part of a cybersecurity learning assignment. The system simulates a chatbot designed to educate users about cybersecurity concepts such as phishing, password safety, two-factor authentication (2FA), and safe online behaviour.

The chatbot goes beyond simple responses by including interactive learning features such as a quiz game, task management system, activity logging, and basic natural language processing (NLP) simulation using keyword detection.

Purpose of the System

The purpose of this application is to:

Educate users about cybersecurity threats and safety practices
Provide an interactive learning experience
Simulate real-world chatbot behaviour using NLP techniques
Demonstrate software development skills using C# and Windows Forms
Apply object-oriented programming principles in a real application

Key Features
1. Chatbot Engine
Responds to user input using keyword detection
Simulates NLP using string matching techniques
Recognises sentiment (positive/negative inputs)
Stores simple memory (e.g., user name)

2. Task Management System
Users can add cybersecurity-related tasks
Example: “Enable 2FA”, “Update password”
View all current tasks
Mark tasks as completed or delete tasks
Tracks tasks using an in-memory list structure

3. Cybersecurity Quiz Game
Interactive multiple-choice quiz
Covers topics such as phishing, malware, passwords, and online safety
Provides instant feedback after each answer
Tracks user score
Displays final results at the end of the quiz

4. Activity Logging System
Records all major user interactions
Logs actions such as:
Messages sent to chatbot
Tasks created or completed
Quiz attempts
Displays last 10 activities for review

5. Voice Feature
Plays a WAV audio file greeting using SoundPlayer
Enhances user experience with audio feedback

6. NLP Simulation
Detects keywords such as:
“password”
“phishing”
“task”
“quiz”
Responds differently based on detected intent
Uses simple string manipulation instead of full AI/NLP libraries

Technologies Used
C# (.NET Windows Forms)
Visual Studio 2022
Object-Oriented Programming (OOP)
File Handling (for logs/tasks if enabled)
System.Media (for audio playback) 

CyberChatbot/
│
├── Core/
│   ├── ChatbotEngine.cs
│   ├── TaskManager.cs
│   ├── TaskItem.cs
│   ├── ActivityLogger.cs
│   ├── KeywordManager.cs
│   ├── SentimentDetector.cs
│   ├── RandomResponses.cs
│   └── MemoryManager.cs
│
├── UI/
│   └── MainForm.cs
│
├── Assets/
│   ├── greeting.wav
│   └── ascii.txt
│
└── Program.cs

How to Run the Project
Open the project in Visual Studio 2022
Restore NuGet packages if needed
Build the solution (Ctrl + Shift + B)
Run the application (F5)
Interact with the chatbot via the GUI

Example Commands
“Add task enable 2FA”
“Show tasks”
“Start quiz”
“My name is John”
“What is phishing?”
“Show activity log”

Learning Outcomes Demonstrated
GUI development using Windows Forms
Event-driven programming
Basic NLP simulation using string matching
Data management using lists and objects
Modular software design using classes
User interaction handling and validation

Future Improvements
Integration with MySQL database for persistent storage
Advanced NLP using AI libraries
Improved UI design with tabs and dashboards
Timer-based reminders for tasks
User authentication system

Author
Cybersecurity Awareness Chatbot Project
Developed as part of academic assignment requirements.
