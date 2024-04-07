# Software Design Document for Camera Simulator

## 1. Introduction
### Purpose of the Document
The purpose of this Software Design Document is to provide a comprehensive overview of the design considerations, architecture, and components of the application Camera Simulator. The Camera Simulator is designed to emulate a camera system with various shooting modes, photo capture, video recording, and gallery management features. 
This document presents the high-level design architecture, component descriptions, user interface design, maintenance guidelines for the Camera Simulator app. 

## 2. Design Goals and Considerations
### Goals
- Simulate different camera shooting modes (Auto, Portrait, Standard, Timer, Video).
- Capture photos and record videos based on selected shooting modes.
- Provide a user-friendly graphical interface for interacting with the camera simulation.
- Implement a robust and scalable design to support future enhancements and modifications.

### Design Considerations
- Performance optimization for real-time camera simulation.
- Modular and extensible architecture to accommodate new shooting modes or features.
- User interface design for intuitive interaction and feedback.

## 3. System Architecture
### High-Level Architecture
The Camera Simulator follows a layered architecture:
- Presentation Layer: User interface components (forms, buttons).
- Application Layer: Camera logic and mode implementations.
- Data Layer: Interaction with the file system for photo/video storage.

### Components 
- `MainScreenForm`: Main application form for camera simulation.

- `Camera`: Manages the current camera mode and photo/video capture.

- `ShootingMode`: Represents different shooting modes.

- `VideoPlayerForm`: Handles video playback functionality.

- `ConcretePhotobuilder`:  Built photos based on certain structure 

- `GalleryMomento` and `GalleryTake`:   Makes the gallery of the photos 

  

## 4. Detailed Design
### Module Descriptions

#### `MainScreenForm`

- **Description**:
  `MainScreenForm` is the main application form responsible for simulating camera functionalities. This form displays camera modes (Auto, Portrait, Standard, Timer, Video) and provides user interface controls such as buttons for mode selection and actions.
  - Displays camera modes and mode-specific controls.
  - Handles user interactions, such as button clicks and mode selections.
  - Triggers camera actions based on user input, such as capturing photos or recording videos.

#### `Camera`

- **Description**:
  `Camera` is a class responsible for managing the current camera mode and facilitating photo/video capture operations. It encapsulates the logic for interacting with different shooting modes (`ShootingMode`) and uses a `ConcretePhotoBuilder` to construct images based on the selected mode.
  - Manages the current shooting mode selected by the user.
  - Coordinates photo/video capture operations based on the selected mode.
  - Utilizes a photo builder (`ConcretePhotoBuilder`) to construct images/videos with specific attributes defined by the shooting mode.

#### `ShootingMode`

- **Description**:
  `ShootingMode` is an abstract base class that defines the behavior and characteristics of different shooting modes available in the Camera Simulator. Derived classes (e.g., `AutoMode`, `PortraitMode`, `StandardMode`, `TimerMode`, `VideoMode`) inherit from `ShootingMode` and implement mode-specific functionalities.
  - Provides an interface for defining common operations and properties of shooting modes.
  - Defines abstract methods and properties that concrete shooting modes must implement.

#### `VideoPlayerForm`

- **Description**:
  `VideoPlayerForm` is a form dedicated to handling video playback functionality within the Camera Simulator. It uses a Windows Media Player control to display and play video files selected by the user.
  - Loads and plays video files using the Windows Media Player control.
  - Provides playback controls (e.g., play, pause, stop) for video files.
  - Supports user interaction for navigating and controlling video playback.

#### `ConcretePhotoBuilder`

- **Description**:
  `ConcretePhotoBuilder` is a class that implements the `PhotoBuilder` interface to construct photos based on a specific structure or format defined by the camera mode. It works in conjunction with the `Camera` class to build images according to mode-specific parameters.
  - Implements the `PhotoBuilder` interface to define photo construction operations.
  - Constructs photos with specific attributes (e.g., size, resolution) based on the current shooting mode.
  - Supports the creation of images using mode-specific configurations and settings.

#### `GalleryMemento` and `GalleryTake`

- **Description**:
  `GalleryMemento` and `GalleryTake` are classes that implement the Memento design pattern to manage the state of a photo gallery within the Camera Simulator. `GalleryMemento` represents a snapshot of gallery images, while `GalleryTake` acts as a caretaker that maintains a history of gallery states.
  - `GalleryMemento` encapsulates the state of the gallery (list of images) at a specific point in time.
  - `GalleryTake` manages a stack of `GalleryMemento` objects, allowing for undo/redo functionality to restore previous gallery states.
  - Enables the Camera Simulator to maintain and manipulate the state of the photo gallery efficiently.

### Design Decisions
- Utilize polymorphism to switch between different shooting modes dynamically.
- Use the Builder pattern to construct photos based on mode-specific parameters.

### User Interface Elements
- Buttons for selecting camera modes (Auto, Portrait, Standard, Timer, Video).
- Picture box for displaying captured photos or video frames.
- Gallery button to view saved photos.
