## **Start Documnet - Design Patterns**



##### **Description** 

Camera has different mode of shootings. The camera should support at least six shooting modes: Auto, Portrait, Standard, Hybrid, Manual, and Timer. Users can effortlessly switch between modes by pressing a designated button on the camera interface.

Auto Mode: Automatically adjusts camera settings for optimal photo capture.

Portrait Mode:  Enhances settings for capturing portrait shots with a blurred background.

Standard Mode: Default mode with standard camera settings.

Hybrid Mode: Combines features of different modes for versatile shooting conditions.

Manual Mode: Allows users to manually adjust settings like exposure, focus, and aperture.

Timer Mode: Enables users to set a timer for delayed photo capture.

The camera interface includes a circle button that users can press to switch between shooting modes. Each mode is visually represented on the UI for easy identification.



##### **Design Patterns:**

1. **Factory Method:**
   - Define an interface (e.g., `ShootingMode`) for different shooting modes.
   - Create concrete classes for each shooting mode (e.g., `AutoMode`, `PortraitMode`, etc.).
   - It creates instances of these concrete classes based on the selected shooting mode.
3. **Builder:**
   - Create a `CameraModeBuilder` that constructs a `CameraMode` with various settings based on the selected shooting mode.
4. **State:**
   - Represent each shooting mode as a state in a `CameraState` context.
   - Switching between modes changes the state of the camera, affecting its behavior.
6. **Decorator:**
   - Add optional features to each shooting mode dynamically.
   - A`BlurredBackgroundDecorator` can be applied to the `PortraitMode` to enhance its features.



##### **Architecture:**

The camera system follows a MVVM (Model-View-ViewModel) architecture

##### **Controller / ViewModel:**

 \- Manages user inputs and interactions.

 \- Handles the communication between the view and the model, ensuring seamless mode switching.



**Class Diagram:**





**MOSCOW analysis:**

| MUST have | SHOULD have | COULD have | WON'T have |
| --------- | ----------- | ---------- | ---------- |
|           |             |            |            |
|           |             |            |            |
|           |             |            |            |

**Conclusion:**



**Information about developers:**

| Developer name      | Email                                     |
| ------------------- | ----------------------------------------- |
| Polina Zueva        | polly.zueva@student.nhlstenden.com        |
| Nathan Pais D'Costa | nathan.pais.dcosta@student.nhlstenden.com |

