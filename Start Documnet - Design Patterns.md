## **Start Documnet - Design Patterns**



##### **Description** 

The Camera simulator has different mode of shootings. The camera should support at least 5 shooting modes: Auto, Portrait, Standard, Hybrid, and Timer. Users can effortlessly switch between modes by pressing a button on the camera interface and there will be made a photo with different image size. Output (photo) is returned in text and is differed from the selected mode.
For instance: "photo of Landscape, 1280 x 720 px" made in Standard mode or "portrait photo, 1080 x 1350 px" made in Portrait mode.

Auto Mode: Automatically adjusts camera settings for optimal photo capture and has standard image size of 1080 x 1920 px.

Portrait Mode:  Enhances settings for capturing portrait shots with a blurred background and has image size of 1080 x 1350 px.

Standard Mode: Default mode with standard camera settings and has standard image size of 1280 x 720 px.

Hybrid Mode: Combines features of different modes for shooting videos in HD format with resolution of 1080p HD at 60fps.

Timer Mode: Enables users to set a 5 seconds timer for delayed photo capture, has the same image size as Auto mode. 

The camera interface includes a circle button that users can press to switch between shooting modes and timer (Timermode). Each mode is visually represented on the UI for easy identification.

- User can press the button to switch between modes
- Method `pressButton()` contains triggers of the mode switch 
- Timer class contains methods such as  `startTimer()`, `stopTimer()`, and `displayTimer()`.




##### **Design Patterns:**

1. **State Method:** (for creating instances of different shooting modes)

- An interface `ShootingMode`, that declares methods corresponding to different actions in each shooting mode (takePhoto, getImageSize).
- Create classes for each shooting mode  `AutoMode`, `PortraitMode`, `StandardMode`, `HydridMode`, `TimerMode`. 
- When the user presses the button to switch between modes. 

2. **Builder:** (for constructing photo object step by step)

- Each shooting mode can have its own PhotoBuilder responsible for constructing the photo with the specific characteristics.
- A photo class represents the final output that you want to create. It can have attributes like description and image_size.
- The PhotoBuilder interface with methods for building different attributes of the Photo (buildDescription() and buildImageSize()). Implementing PhotoBuilder for each shooting mode (AutoModePhotoBuilder, PortraitModePhotoBuilder)
- PhotoDirector class is responsible for coordinating the construction process. It takes a PhotoBuilder as a parameter and calls its methods to construct the Photo.


3. **Strategy:**

- In the interface ShootingMode the method capturePhoto() is declared.
-  `AutoSettingsStrategy` -  Implement the `CameraSettingsStrategy` interface, defining specific algorithms for adjusting camera settings.
- `Camera` -  Contains a reference to the current strategy and delegates the task of adjusting settings to the selected strategy.
- ShootingMode as a strategy. The capturePhoto() method in the Camera class delegates the photo capture task to the current strategy.


##### **Architecture:**

The camera system follows a MVVM (Model-View-ViewModel) architecture

##### **Controller / ViewModel:**

 \- Manages user inputs and interactions.

 \- Handles the communication between the view and the model, ensuring seamless mode switching.


**Class Diagram:**

<img width="821" alt="Class diagram" src="https://github.com/Polinalavender/Design-Patterns/assets/91316935/ccddea6c-e181-4822-8e0e-c9ef354482e3">





**MOSCOW analysis:**

| MUST have                                                    | SHOULD have                                                  | COULD have                                                   | WON'T have                                                   |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Switch Between Modes<br />** The ability for users to switch between shooting modes by pressing a button on the camera interface. | **UI Representation** <br />Each mode should be visually represented on the UI. | **Additional Shooting Modes** <br />The possibility of adding more shooting modes manually. | **Connection camara to different devices**<br />Possibility  to connect camera to the phone to trasfer photos |
| The output is photo, given in text (String)                  |                                                              |                                                              |                                                              |



**Information about developers:**

| Developer name | Email                              |
| -------------- | ---------------------------------- |
| Polina Zueva   | polly.zueva@student.nhlstenden.com |

