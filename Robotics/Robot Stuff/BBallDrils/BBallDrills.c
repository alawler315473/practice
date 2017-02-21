
void moveForward()
{
	motor[port2] = -127;
	motor[port3] = 127;
	wait1Msec(1200);
}

void moveBackward()
{
	motor[port2] = 127;
	motor[port3] = -127;
	wait1Msec(1200);
}

task main()
{
	moveForward();
	moveBackward();

	moveForward();
	moveForward();
	moveForward();

	moveBackward();
	moveBackward();
	moveBackward();

	moveForward();
	moveForward();
	moveForward();
	moveForward();
	moveForward();

	moveBackward();
	moveBackward();
	moveBackward();
	moveBackward();
	moveBackward();
}
