# Scoped-Singleton-Transient
Purpose of this project is to demonstrate the diffrence among Scoped, Singleton and Transient


Case 1: Singleton

When we inject dependency as singleton in Program.cs it can bee seen that only one instance of StudentRepository is available throught the application.
Create method adds student in same instance and can be seen that count is increasing. Also if we go to the Index method of Student Controller all the students can be seen in the table which proves that by using Singleton only one instance will be injected for any number of request.
