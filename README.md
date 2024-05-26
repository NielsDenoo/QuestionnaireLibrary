# Questionnary Game

## Project Description

The Questionnary Game is a trivia quiz application implemented in WPF. It features a friendly user interface where users can answer multiple-choice questions, track their scores, and view a scoreboard.

- **QuestionnaryLibrary**: Manages question and answers.
- **ConsoleApp**: This is to test the classes.
- **Questionnaire-The-Game**: The main question game with scoreboardwindow included.
- **TriviaApiLibrary**: Retrieves trivia questions from an API.
- **ScoreboardLibrary**: Manages the scoreboard and player scores.

## Author

This app is made by Niels Denoo during his studies at VIVES Brugge 2024.

## Screenshots

- Start window

![StartWindow](./images/Startwindow.png)

- Questions

![Questions](./images/Questions.png)

- SubmitUser

![SubmitUser](./images/SubmitUser.png)

- Scoreboard

![Scoreboard](./images/Scoreboard.png)

- Aboutwindow

![AboutWindow](./images/AboutWindow.png)

## Setup and Usage

To use this application u need to install Visual Studio. You can do this by following [Link](https://visualstudio.microsoft.com/vs/community/). After installation u need to run QuestionnaireLibrary.sln in visual studio.

## UML Class Diagrams

### QuestionnaireLibrary

```mermaid
classDiagram
direction LR
class Answer {
  +Text: string
  +IsCorrect: boolean
  +Answer(text: string, isCorrect: bool)
  +ToString() string
}

class Question {
  -possibleAnswer: List~Answer~
  +<< get/set >>Text: string
  +<< get/set >>ImageUrl: string
  +<< get/set >>Answers: List~Answer~
  +Question(text: string)
  +Add(answer: Answer)
  +GetAnswer(index: int) Answer
  +ToString() string
}

Answer --o Question
```

### Scoreboardlibrary

```mermaid
classDiagram
direction RL
class Scoreboard {
  -scoreList: List~PlayerScore~
  +Scoreboard()
  +AddPlayer(player: PlayerScore)
  +SortScoreboard()
  +ToString() string
}

class PlayerScore {
  -name: string
  -score: int
  +<< get/set >>Name: string
  +<< get/set >>Score: int
  +PlayerScore(name: string, score: int)
  +ToString() string
}

PlayerScore --o Scoreboard
```

## Future Improvements

- **Add difficulty choice**: Allow users to select harder or easier questions instead of mixing all together.