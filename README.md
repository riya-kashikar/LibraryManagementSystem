# Library Management System


## Overview
This is a console-based Library Management System implemented in C#. It demonstrates the use of Object-Oriented Programming (OOP) principles, SOLID design principles, and design patterns such as Singleton and Factory.

## Features
Add new books or eBooks to the library.
Remove books by ISBN.
Search for books by title.
List all available books in the library.
Display file size for eBooks.
Implements the Singleton and Factory design patterns.

## Project Structure

LibraryManagementSystem/
├── Book.cs                  
├── EBook.cs                
├── Library.cs             
├── LibraryManager.cs     
├── SingletonLibraryManager.cs 
├── BookFactory.cs           
├── Program.cs               

## Demonstrated Concepts
OOP Principles:
Encapsulation, Inheritance, Polymorphism.
SOLID Design Principles:
Single Responsibility Principle (SRP): Each class has a well-defined responsibility.
Design Patterns:
Singleton Pattern: Ensures a single instance of LibraryManager.
Factory Pattern: Creates Book or EBook objects dynamically.

## How I run the code:
Setup dotnet console by command “dotnet new console”
It will make a project by name same as folder name
Make other necessary C# files 
Run command “dotnet run”, this Compile and run the Program.cs file.
