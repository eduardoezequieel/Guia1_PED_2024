using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Guia1
{
    public partial class Ejemplo3 : Form
    {
        enum Position
        {
            LEFT, RIGHT, UP, DOWN
        }

        private const int INITIAL_SPEED = 110;
        private List<Point> snake;
        private int snakeSegmentSize = 20;
        private Position objPosition;
        private Position prevObjPosition;
        private Random random;
        int foodX, foodY = -100;

        public Ejemplo3()
        {
            InitializeComponent();
            snake = new List<Point>();
        }

        private void StartGame()
        {
            timermov.Start();
            timermov.Interval = INITIAL_SPEED;
            prevObjPosition = Position.RIGHT;
            objPosition = Position.RIGHT;
            random = new Random();

            snake = new List<Point>
            {
                new Point(60, 60),
                new Point(40, 60),
            };

            GenerateFood();
        }

        private void FinishGame() {
            timermov.Stop();
            timermov.Interval = INITIAL_SPEED;

            foodX = -100;
            foodY = -100;

            snake = new List<Point>();

            MessageBox.Show("Game Over");
        }

        private void GenerateFood()
        {
            int maxCellsX = drawArea.Width / snakeSegmentSize;
            int maxCellsY = drawArea.Height / snakeSegmentSize;

            if (timermov.Interval > 30)
            {
                timermov.Interval -= 5;
            }

            Console.WriteLine(timermov.Interval);

            Point newFoodPosition;
            bool positionOnSnake;

            do
            {
                // Generate random position within grid bounds
                foodX = random.Next(0, maxCellsX) * snakeSegmentSize;
                foodY = random.Next(0, maxCellsY) * snakeSegmentSize;
                newFoodPosition = new Point(foodX, foodY);

                // Check if the new position is on the snake
                positionOnSnake = snake.Contains(newFoodPosition);
            } while (positionOnSnake); // Repeat until we find a position not on the snake
        }

        private void MoveSnake()
        {
            for (int i = snake.Count - 1; i > 0; i--)
            {
                snake[i] = snake[i - 1];
            }

            switch (objPosition)
            {
                case Position.RIGHT:
                    snake[0] = new Point(snake[0].X + snakeSegmentSize, snake[0].Y); break;
                case Position.LEFT:
                    snake[0] = new Point(snake[0].X - snakeSegmentSize, snake[0].Y); break;
                case Position.UP:
                    snake[0] = new Point(snake[0].X, snake[0].Y - snakeSegmentSize); break;
                case Position.DOWN:
                    snake[0] = new Point(snake[0].X, snake[0].Y + snakeSegmentSize); break;
            }
        }

        private void timermov_Tick(object sender, EventArgs e)
        {
            MoveSnake();

            if (snake[0].X < 0 || snake[0].X >= drawArea.Width || snake[0].Y < 0 || snake[0].Y >= drawArea.Height)
            {
                FinishGame();
                return;
            }

            for (int i = 1; i < snake.Count; i++)
            {
                if (snake[0] == snake[i])
                {
                    FinishGame();
                    return;
                }
            }

            if (snake[0].X == foodX && snake[0].Y == foodY)
            {
                snake.Add(new Point(-100, -100));
                GenerateFood();
            }

            drawArea.Invalidate();
        }

        private void Ejemplo3_KeyDown(object sender, KeyEventArgs e)
        {
            prevObjPosition = objPosition;

            if (e.KeyCode == Keys.Left && prevObjPosition != Position.RIGHT)
            {
                objPosition = Position.LEFT;
            }
            else if (e.KeyCode == Keys.Right && prevObjPosition != Position.LEFT)
            {
                objPosition = Position.RIGHT;
            }
            else if (e.KeyCode == Keys.Up && prevObjPosition != Position.DOWN)
            {
                objPosition = Position.UP;
            }
            else if (e.KeyCode == Keys.Down && prevObjPosition != Position.UP)
            {
                objPosition = Position.DOWN;
            }
        }

        private void btnStart_MouseClick(object sender, MouseEventArgs e)
        {
            StartGame();
        }

        private void btnFinish_MouseClick(object sender, MouseEventArgs e)
        {
            FinishGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FinishGame();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Draw snake
            foreach (var segment in snake)
            {
                e.Graphics.FillRectangle(Brushes.Green, segment.X, segment.Y, snakeSegmentSize, snakeSegmentSize);
            }

            // Draw food
            e.Graphics.FillRectangle(Brushes.Red, foodX, foodY, snakeSegmentSize, snakeSegmentSize);
        }
    }
}
