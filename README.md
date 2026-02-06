# Quiz Game
This is a windows form quiz game. 
Where you can get questions and if you answer them right you get +1 score.
There are total of 10 questions.

# How it works
The questions are stored in a dictionary the keys being questions and the values being the answers.
When you press the "New Question" button it generates a random number between 1-10.
It stores the random values it have given before so that you don't get the same question again.
When you enter the answer and press the "Answer" button it checks if the answer is equal to the value in the dict.
If it is then you get a point.
When you have answered all the questions the random numbers reset and it show you your final score.
