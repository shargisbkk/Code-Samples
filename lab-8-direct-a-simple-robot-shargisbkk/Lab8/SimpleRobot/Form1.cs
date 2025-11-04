namespace SimpleRobot
{
    public partial class Form1 : Form
    {
        Robot robot = new Robot();

        public Form1()
        {
            InitializeComponent();
            SetDirection(robot.CurrentDirection);
            UpdatePositionLabel();
            UpdateArrowPosition();
            // sends the event handler to the robot class
            robot.TooFar += OutOfBounds;
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            SetDirection(Robot.Direction.North);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            SetDirection(Robot.Direction.East);

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            SetDirection(Robot.Direction.South);

        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            SetDirection(Robot.Direction.West);
        }
        private void SetDirection(Robot.Direction direction)
        {
            // set the robots direction based on button sent
            robot.CurrentDirection = direction;

            // switch statement assigns the direction's wingding charcode to the variable, defaults to North
            char arrowChar = direction switch
            {
                Robot.Direction.North => (char)233,
                Robot.Direction.South => (char)234,
                Robot.Direction.East => (char)232,
                Robot.Direction.West => (char)231,
                _ => (char)233
            };
            lblRobot.Text = arrowChar.ToString();
        }

        private void btnMove1_Click(object sender, EventArgs e)
        {
            robot.MoveRobot(1);
            UpdatePositionLabel();
            UpdateArrowPosition();
        }

        private void btnMove10_Click(object sender, EventArgs e)
        {
            robot.MoveRobot(10);
            UpdatePositionLabel();
            UpdateArrowPosition();
        }
        private void UpdatePositionLabel()
        {
            lblPosition.Text = $"({robot.position.X}, {robot.position.Y})";
        }
        private void UpdateArrowPosition()
        {
            int centerX = pnlWorld.Width / 2;
            int centerY = pnlWorld.Height / 2;

            // the position of the robot, relative to the center of the parent panel, is assigned to the label's position
            // according to the top left corner of their outerbounds boxes and adjusts for the label size
            lblRobot.Left = centerX + robot.position.X - lblRobot.Width/2;
            lblRobot.Top = centerY - robot.position.Y - lblRobot.Height/2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // event handler for when the robot goes out of bounds, nullable because it may not be used
        private void OutOfBounds(object? sender, EventArgs e)
        {
            MessageBox.Show("If you take one more step. It'll be the furthest from home you've ever been. Mordor can wait.");
        }
    }
}
