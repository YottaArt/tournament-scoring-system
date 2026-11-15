# Tournament Scoring System

A C# Windows Forms desktop application for managing and calculating scores in a school sports tournament.

## Overview

The Tournament Scoring System was developed as a programming project using C# and Windows Forms.

The application is designed for a tournament involving four teams, with five participants in each team. It allows users to assign sports and finishing positions to participants, configure scoring values and automatically calculate individual and team scores.

## Screenshots

### Main application interface

<figure>

<figcaption aria-hidden="true">Tournament Scoring System - Main Interface</figcaption>
</figure>

### Participant ranking selection

<figure>

<figcaption aria-hidden="true">Participant Ranking Selection</figcaption>
</figure>

## Features

- **Four predefined teams:** Each team contains five participants.
- **Participant allocation:** Each participant has an individual selection field.
- **Multiple sports:** Includes Running, Jumping, Swimming, Chess and Rowing.
- **Ranking selection:** Participants can be assigned 1st, 2nd or 3rd place in their selected sport.
- **Customisable scoring:** Users can enter the points awarded for each finishing position.
- **Automatic calculations:** Individual scores and team totals are calculated automatically.
- **Reset functionality:** Clears the current tournament selections and resets the scores.
- **Exit functionality:** Allows users to close the application with a confirmation prompt.

## Technologies Used

- C#
- .NET Framework 4.7.2
- Windows Forms (WinForms)
- Microsoft Visual Studio

## Technical Implementation

The project uses several C# programming concepts:

- **Dictionaries:** Used to associate participant selections with scoring values and corresponding score displays.
- **Integer variables:** Used to store the points awarded for each finishing position.
- **Functions:** Used to organise score calculations, reset operations and other application functionality.
- **Event handling:** Used to respond to changes in participant selections and button interactions.
- **Windows Forms controls:** ComboBoxes, TextBoxes, Labels, GroupBoxes and Buttons are used to create the graphical interface.

The available sports and ranking combinations are configured through the Windows Forms Designer in Visual Studio.

## Scoring System

Users can configure the points awarded for the top three finishing positions.

The default scoring values are:

| Position  | Points |
|-----------|-------:|
| 1st place |     25 |
| 2nd place |     18 |
| 3rd place |     15 |

Each participant’s selection determines their individual score. The application then calculates the total points for the corresponding team.

The `None` option is also available as a placeholder in the participant selection fields. In the current implementation, it returns the third-place scoring value.

## Testing and Debugging

The application was manually tested to verify:

- Correct score assignment for different sports and rankings.
- Accurate individual participant scores.
- Correct calculation of team totals.
- Reset functionality.
- Application interface layout and control behaviour.

During development, several issues were identified and resolved, including:

- Text clipping in ranking ComboBoxes.
- Incorrect application window dimensions.
- Incorrect allocation of scores between teams.

## Limitations

- Supports four predefined teams with five participants each.
- Participant names cannot currently be customised.
- Each participant is assigned one sport.
- Tournament results are not permanently saved.
- The application currently runs through Visual Studio and does not include a standalone installer or published release.

## Building and Running

1.  Clone or download this repository.
2.  Open `TournamentSys.slnx` in Microsoft Visual Studio.
3.  Ensure the .NET Framework 4.7.2 targeting pack is installed.
4.  Build the solution.
5.  Run the application through Visual Studio.

## Learning Outcomes

Through this project, I developed my understanding of:

- Creating and organising functions in C#.
- Implementing calculations and application logic.
- Working with dictionaries and Windows Forms controls.
- Debugging and resolving programming errors.
- Testing application functionality and verifying calculation accuracy.
