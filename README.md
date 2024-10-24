## W4_EndTask - Patika+ Back-End Bootcamp Week 4 Ending Task

This project manages Phone and Computer records in a technology store. The system handles information such as production date, serial number, description, and specific attributes for both phones and computers, using principles of **Object-Oriented Programming** (OOP) such as **inheritance**, **encapsulation**, **polymorphism**, and **abstraction**.

### Features

- **Inheritance**: 
  - Both `Telephone` and `Computer` classes inherit from a base class `BaseMachine`.
  
- **Encapsulation**:
  - The number of USB inputs for computers can only be set to `2` or `4`. If another value is provided, the system gives a warning and sets the USB input number to `-1`.

- **Polymorphism**:
  - The base class `BaseMachine` contains a method `PrintInfo()` to print common information like the production date, serial number, name, description, and operating system.
  - This method is overridden in the derived classes (`Telephone` and `Computer`) to include class-specific properties.

- **Abstraction**:
  - An abstract method `GetProductName()` is defined in the base class and overridden in the derived classes to print unique messages for each object:
    - For Phones: `$"Telephone Name: {Name}"`
    - For Computers: `$"Computer Name: {Name}"`

### Classes and Attributes

### BaseMachine
The base class for all devices (phones and computers). It contains common attributes and methods for:
- **Date of Production** (automatically assigned upon object creation)
- **Serial Number**
- **Name**
- **Description**
- **Operating System**

### Phone (Inherits from BaseMachine)
Specific attributes for the `Telephone` class:
- **TR Licensed**: Indicates whether the phone is licensed in Turkey.

### Computer (Inherits from BaseMachine)
Specific attributes for the `Computer` class:
- **Number of USB Inputs**: Can only be `2` or `4`, otherwise a warning is issued and a default value of `-1` is set.
- **Bluetooth Support**: Indicates whether the computer has Bluetooth capability.

## Program Flow

1. The user is prompted to press `1` to create a phone or `2` to create a computer, `3` to exit.
2. Based on the user's input, an object from the respective class (`Telephone` or `Computer`) is instantiated.
3. The system collects the relevant properties for the object from the user via the console and stores them.


