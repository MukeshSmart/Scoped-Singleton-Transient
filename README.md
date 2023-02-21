# Scoped-Singleton-Transient
Purpose of this project is to demonstrate the diffrence among Scoped, Singleton and Transient


**Case 1: Singleton**

When we inject dependency as singleton in Program.cs it can bee seen that only one instance of StudentRepository is available throught the application.
Create method adds student in same instance and can be seen that count is increasing. Also if we go to the Index method of Student Controller all the students can be seen in the table which proves that by using Singleton only one instance will be injected for any number of request.

A Singleton service is created when it is first requested. This same instance is then used by all the subsequent requests. So in general, a Singleton service is created only one time per application and that single instance is used throughout the application life time.


**Case 2: Scoped**

A new instance of a Scoped service is created once per request within the scope. For example, in a web application it creates 1 instance per each http request but uses the same instance in the other calls within that same web request.

