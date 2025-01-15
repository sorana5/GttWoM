Virtual Piano Music Learning Application
Description
Music plays a vital role in our lives, whether it is through singing, playing an instrument, or simply listening in various settings or moods. Inspired by my passion for music, I created this application to introduce users to the world of music. The app provides an interactive way to learn music theory, practice piano skills, and even test your abilities, all while playing a virtual piano. Users can explore basic music concepts, play songs, and track their high scores.

Project Flow
Start (Form 1) – Initial entry point of the application.
Authenticator (Form 7) – Login and authentication system for students and teachers.
Teacher View (Form 8) – Teachers can manage the class and delete students based on their usernames.
Student View:
Summary (Form 2): Students can choose between Theory, Piano Practice, or Testing.
Music Theory: Theory (Form 5) – Learn music theory concepts with visual aids.
Piano Practice: Piano (Form 3) – Play notes on a virtual piano and see them on the musical staff.
Testing: Testing (Form 4) – Practice and verify your note-playing skills.
Song Melody: Play (Form 6) – Play a random song and earn points based on accuracy.
Key Features
AppDbContext: Connects the application to a database for storing users and scores.
Student and Teacher Management: Allows adding and managing students and teachers, as well as providing score tracking and class management.
Note Handling: Handles the conversion and drawing of musical notes, including accidentals (sharps and flats), and supports different key signatures.
Song Management: Stores and handles the songs available for practice and testing.
Piano: Virtual piano with the ability to play up to 10 notes, including sharp and flat notes.
Authentication System: Ensures that usernames are unique and passwords are securely encrypted.
Leaderboard: Allows teachers to view and manage student performance.
Music Theory Tutorial: Step-by-step tutorial on music theory concepts, enhanced with images for better understanding.
Testing Module: Random note generation for students to practice, with a verification system to check their accuracy.
Features in Detail
Authentication:
Unique usernames required for each user.
Password encryption ensures security.
Theory (Music Theory):
Theoretical lessons on music, including scales, keys, and note values.
Images and diagrams to visualize musical concepts.
Piano Practice:
Virtual piano that displays notes on the musical staff as they are played.
Allows the user to erase notes and adjust sharp/flat values.
Testing:
Generate random notes for the student to play.
Check the accuracy of notes and scores.
Receive feedback based on performance.
Song Melody:
A random song is selected for the student to play.
Notes are displayed on the staff, and the user needs to play them on the piano.
Correctly playing a song grants significantly more points than practicing individual notes.
Technologies Used
C# – Primary programming language.
Entity Framework Core – For database interaction.
Windows Forms – For creating the graphical user interface (GUI).
PostgreSQL – For database storage and user management.
.NET Framework – Used for the application framework.