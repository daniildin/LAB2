# LAB2
/* UML Diagram

DiceGame            
 - dice1: Dice                
 - dice2: Dice                
 - rounds: int                
 - dice1Wins: int             
 - dice2Wins: int             

 + PlayGame(): void           
 + GetWinner(): string        


Dice                 

 - sides: int                
 - topSide: int               

 + Roll(): int                
 + GetTopSide(): int          
 + IsNumberInArray(rolls: int[], number: int): bool
 + GenerateUniqueNumbersArray(): List<int>

*/

# Dice Rolling Game

This is a simple C# program simulating a dice rolling game where two dice are rolled and compared over multiple rounds. It tracks wins, ties, and unique numbers rolled.

## Classes

### Dice Class
- Represents a dice with customizable sides.
- **Methods**:
  - `Roll()`: Simulates a roll and returns a number between 1 and the number of sides.
  - `GetTopSide()`: Returns the last rolled number.
  - `IsNumberInArray(rolls, number)`: Checks if a number exists in the array of rolls.
  - `GenerateUniqueNumbersArray()`: Rolls the dice until all sides are rolled at least once.

### DiceGame Class
- Simulates a game where two dice are rolled and compared.
- Tracks wins and ties for each dice.

## Output Example
```plaintext
Dice 1 wins: 3, Dice 2 wins: 2, Ties: 0
