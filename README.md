# Contact Management System

A console-based Contact Management System implemented in C#. This repository is a compact practice project designed to exercise object-oriented programming (OOP) fundamentals, basic application architecture, file handling, and common CRUD workflows.

The application provides a simple, interactive command-line interface for creating, viewing, editing, searching, and deleting contacts persisted to a local JSON file.

## Purpose and audience

This project was developed as a focused learning exercise to solidify OOP concepts (classes, encapsulation, separation of concerns) and to practice building a small, self-contained application from end-to-end. It is suitable for:

- Developers learning or reinforcing OOP and C# fundamentals.
- Students building portfolio projects that show practical application structure.
- Anyone who wants a minimal, extensible example of a console CRUD application with JSON persistence.

The initial implementation was completed over the course of one week as a hands-on experiment to get up to speed with new tools, patterns, and runtime behaviors.

## Key goals and learning outcomes

- Apply core OOP principles (classes, constructors, encapsulation, simple domain models).
- Design a minimal but maintainable application architecture with clear responsibilities.
- Implement reliable serialization and file I/O using JSON to persist application state.
- Build a user-friendly console UI for common CRUD operations and simple navigation.
- Practice iterative improvement: refactoring, UI polish, and small automated checks where appropriate.

## Features

- Add Contact
  - Create a new contact by providing a nickname, first name, last name, and contact number.
  - Input validation is handled at the menu/handler level to ensure consistent data.

- View Contacts (Contact List)
  - Shows a numbered list of saved contacts with their nicknames.
  - Displays a count of total contacts for quick overview.

- Contact Details
  - Select a contact by its displayed number to view full details: nickname, first name, last name, and contact number.
  - Navigation options to return, edit, or delete the selected contact.

- Edit Contact
  - Update any of the fields of a contact; fields can be left unchanged by submitting blank input.
  - Updates are saved back to the JSON storage immediately.

- Delete Contact
  - Delete a contact with a confirmation prompt to prevent accidental removal.
  - Changes are persisted to JSON after deletion.

- Search
  - Search contacts by nickname (case-insensitive exact match) to quickly find entries.

- Persistence
  - All contacts are stored in a local JSON file via a small JSON handler component.
  - Saving and loading are encapsulated so persistence can be swapped or extended later.

## Architecture & code structure

The code is organized with separation of concerns in mind:

- Domain model
  - Person: represents a contact and provides basic update behavior.

- Management / Storage
  - ContactManagement: application-level manager for the in-memory collection of contacts and persistence operations.
  - JsonHandler: responsible for reading and writing the contact list to disk as JSON.

- UI / Navigation
  - Menu, ContactCreationMenu, ManageContactsMenu: console UI classes responsible only for rendering text and reading user input. They invoke the management layer to perform actions.
  - MenuNavigation and handlers encapsulate how choices map to behavior.

- Handlers
  - ContactCreationHandler and similar classes provide a small boundary between UI and management logic to keep responsibilities clear.

This layout keeps business logic and persistence separate from presentation, making the code easier to test and extend.

## Running the application

Prerequisites
- .NET SDK (version compatible with the project target; the solution targets .NET 10).

To run locally

1. Open the solution in Visual Studio or use the dotnet CLI:

   dotnet build
   dotnet run --project "Contact Management System"

2. Use the console menus to add, view, edit, search, and delete contacts.

Notes
- The application stores contacts in a JSON file located in the application directory. Ensure the application has write access to that location.

## Extending the project

Suggested improvements and learning exercises:

- Input validation and formatting: add stronger validation for phone numbers, required fields, and duplicate detection.
- Search enhancements: implement partial and fuzzy search, or search by first/last name.
- Import/export: add CSV import/export functionality for interoperability.
- Tests: introduce unit tests for the domain model and JSON persistence layer.
- UI improvements: replace console UI with a minimal web API or GUI to learn a new framework.

## What I learned

Over the week-long development of this project I focused on quickly iterating through feature development while keeping a simple architectural discipline. Major takeaways included:

- Practical experience implementing small, focused classes with clear responsibilities.
- Confidence with JSON serialization and file handling in .NET.
- Improved ability to break a problem into UI, domain, and persistence layers.
- Speeding up learning by building and refining a working, tangible application.

## Tools and technologies

- C# and .NET (project targets .NET 10)
- Visual Studio (recommended) or dotnet CLI
- System.Text.Json for serialization

## Contributing

This repository is intended as an educational example. Contributions that improve clarity, add tests, or refactor code for maintainability are welcome. Please open an issue or pull request describing the change and the motivation.

## License

This project is provided for learning purposes. Add an appropriate license if you intend to distribute or reuse it in other projects.

