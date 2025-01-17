# Virtual Piano Music Learning Application

## Description
Music plays a vital role in our lives, whether through singing, playing an instrument, or simply listening in various settings or moods. Inspired by a passion for music, this application introduces users to the world of music through an interactive platform. The app provides tools to learn music theory, practice piano skills, and test abilities using a virtual piano. Users can explore basic music concepts, play songs, and track their high scores.

---

## Project Flow
- **Start (Form 1):** Initial entry point of the application.
- **Authenticator (Form 7):** Login and authentication system for students and teachers.
- **Teacher View (Form 8):** Teachers can manage the class and delete students based on their usernames.
- **Student View:**
  - **Summary (Form 2):** Choose between Theory, Piano Practice, or Testing.
  - **Music Theory (Form 5):** Learn music theory concepts with visual aids.
  - **Piano Practice (Form 3):** Play notes on a virtual piano and see them displayed on the musical staff.
  - **Testing (Form 4):** Practice and verify note-playing skills.
  - **Song Melody (Form 6):** Play a random song and earn points based on accuracy.

---

## Key Features

### AppDbContext
- Connects the application to a database for storing users and scores.

### Student and Teacher Management
- Allows adding and managing students and teachers.
- Provides score tracking and class management.

### Note Handling
- Converts and draws musical notes, including accidentals (sharps and flats).
- Supports different key signatures.

### Song Management
- Stores and manages songs for practice and testing.

### Piano
- Virtual piano capable of playing up to 10 notes, including sharps and flats.

### Authentication System
- Ensures unique usernames.
- Encrypts passwords securely.

### Leaderboard
- Enables teachers to view and manage student performance.

### Music Theory Tutorial
- Step-by-step tutorial on music theory concepts.
- Enhanced with images and diagrams for better understanding.

### Testing Module
- Generates random notes for students to practice.
- Verifies accuracy and provides performance feedback.

### Song Melody
- Selects a random song for the student to play.
- Displays notes on the staff and requires accurate piano input.
- Rewards significant points for correctly playing a song.

---

## Features in Detail

### Authentication
- **Unique usernames** required for each user.
- **Password encryption** ensures security.

### Theory (Music Theory)
- Theoretical lessons on music concepts, including scales, keys, and note values.
- Visual aids such as images and diagrams.

### Piano Practice
- A virtual piano that displays notes on the musical staff as they are played.
- Options to erase notes and adjust sharp/flat values.

### Testing
- Random note generation for students to play.
- Accuracy verification and scoring.
- Feedback provided based on performance.

### Song Melody
- A random song is selected for practice.
- Notes are displayed on the staff for the student to replicate on the piano.
- Correctly playing a song grants significantly more points.

---

## Technologies Used
- **C#:** Primary programming language.
- **Entity Framework Core:** For database interaction.
- **Windows Forms:** For creating the graphical user interface (GUI).
- **PostgreSQL:** For database storage and user management.
- **.NET Framework:** Used for the application framework.
