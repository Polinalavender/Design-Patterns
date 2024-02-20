## **Start Documnet - Design Patterns**



##### **Description** 

Camera has different mode of shootings. The camera should support at least six shooting modes: Auto, Portrait, Standard, Hybrid, Manual, and Timer. Users can effortlessly switch between modes by pressing a designated button on the camera interface.

Auto Mode: Automatically adjusts camera settings for optimal photo capture.

Portrait Mode:  Enhances settings for capturing portrait shots with a blurred background.

Standard Mode: Default mode with standard camera settings.

Hybrid Mode: Combines features of different modes for versatile shooting conditions.

Manual Mode: Allows users to manually adjust settings like exposure, focus, and aperture.

Timer Mode: Enables users to set a timer for delayed photo capture.

The camera interface includes a circle button that users can press to switch between shooting modes and timer (Timermode). Each mode is visually represented on the UI for easy identification.

- User can press the button to switch between modes
- Method `pressButton()` contains triggers of the mode switch 
- Timer class contains methods such as  `startTimer()`, `stopTimer()`, and `displayTimer()`.



##### **Design Patterns:**

1. **Factory Method:** (for creating instances of different shooting modes)

   - Define an interface `ShootingMode` for different shooting modes.
   - Create classes for each shooting mode  `AutoMode`, `PortraitMode`, ans etc. 
   - `createShootingMode()`) in the camera class responsible for creating instances of shooting mode classes based on the selected shooting mode.
   - When the user presses the button to switch between modes, the factory method creates an instance of the selected shooting mode, allowing the camera to adapt its behavior accordingly.

2. **Builder:** (for constructing a complex object step by step)

   - Create a `CameraModeBuilder` that constructs a `CameraMode` with various settings based on the selected shooting mode.
   - Methods -  `setExposure()`, `setFocus()`.  Allow configuring specific settings for a shooting mode.
   - When creating a new shooting mode, the `CameraModeBuilder` is used to set specific settings, and then the constructed `CameraMode` is assigned to the camera.

3. **Observer Pattern:** (for separating the camera from its observers. Ensure that the subject - camera notifies observers efficiently)

   - The camera interface that changes its state: shooting modes or timer statuses
   - `ModeObserver` that need to be notified when the shooting mode changes or when the timer is started, stopped, or updated.
   - `registerObserver()`, `removeObserver()`, `notifyObservers()`): Manage the list of observers and notify them of changes.
   - When the user presses the button to switch between modes or manipulates the timer, the camera notifies registered observers, updating UI components accordingly.

4. **Strategy Pattern:**

   -  Represents the strategy for adjusting camera settings.

   - `AutoSettingsStrategy`, `ManualSettingsStrategy` -  Implement the `CameraSettingsStrategy` interface, defining specific algorithms for adjusting camera settings.
   - `Camera` -  Contains a reference to the current strategy and delegates the task of adjusting settings to the selected strategy.
   - When the shooting mode changes, the camera switches to the corresponding strategy, allowing flexible adjustment of camera settings based on the selected mode.

   

##### **Architecture:**

The camera system follows a MVVM (Model-View-ViewModel) architecture

##### **Controller / ViewModel:**

 \- Manages user inputs and interactions.

 \- Handles the communication between the view and the model, ensuring seamless mode switching.



**Class Diagram:**

<img width="801" alt="Class diagram" src="https://github.com/Polinalavender/Design-Patterns/assets/91316935/fdbea623-6aba-4a4e-a222-0b0ed52752a4">




**MOSCOW analysis:**

| MUST have                                                    | SHOULD have                                                  | COULD have                                                   | WON'T have                                                   |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Switch Between Modes<br />** The ability for users to switch between shooting modes by pressing a button on the camera interface. | **Hybrid Mode** <br />The camera should support a Hybrid mode that combines features of different modes for versatile shooting conditions | **Add more Timer Features** <br />Additional features for the Timer mode, such as customizable timer durations or multiple timer settings. | **Connection camara to different devices**<br />Possibility  to connect camera to the phone to trasfer photos |
| **Auto Mode** <br />The camera should support an Auto mode that automatically adjusts camera settings for optimal photo capture. | **Timer Mode** <br />The camera should have a Timer mode that enables users to set a timer for delayed photo capture. <br /> | **Additional Shooting Modes** <br />The possibility of adding more shooting modes manually. |                                                              |
| **Standard Mode** <br />A default mode with standard camera settings. | **UI Representation** <br />Each mode should be visually represented on the UI. |                                                              |                                                              |
| **Manual Mode** <br />The camera should support a Manual mode that allows users to manually adjust settings like exposure and  focus. |                                                              |                                                              |                                                              |



**Information about developers:**

| Developer name | Email                              |
| -------------- | ---------------------------------- |
| Polina Zueva   | polly.zueva@student.nhlstenden.com |

