
task main()
{
	motor[port2] = -147;
	motor[port3] = 147;
	wait1Msec(3200);

	motor[port2] = 113;
	motor[port3] = 112;
	wait1Msec(710);

	motor[port2] = -150;
	motor[port3] = 150;
	wait1Msec(3500);

	motor[port2] = 113;
	motor[port3] = 112;
	wait1Msec(705);

	motor[port2] = -147;
	motor[port3] = 147;
	wait1Msec(3500);

	motor[port2] = 113;
	motor[port3] = 112;
	wait1Msec(705);

	motor[port2] = -147;
	motor[port3] = 147;
	wait1Msec(3500);
}
