

//convert these for loops to while loops
//1
int i=0;
while(i<10){
	Console.WriteLine("Hello World");
	i=i+1;
}

//2
int i=3;
while(i<13){
	Console.WriteLine("Hello World");
	i=i+1;
}

//3
int i=45;
while(i>10){
	Console.WriteLine("Hello World");
	i=i-1;
}

//4
int i=25;
while(i>=10){
	Console.WriteLine("Hello World");
	i=i-3;
}

//5
int i=2;
while(i<128){
	Console.WriteLine("Hello World");
	i=i+i;
}

//6
int i=1;
while(i<50){
	Console.WriteLine("Hello World");
	i=i*3;
}

//7
int j = 0;
while(int i=10;i<13;j=j+1){
	if (j == 7){
		i = i+1;
		j = 0;
	}
	Console.WriteLine("Hello World");
}

//8
int i=0;
while(i<10){
	i=i+2;
	if (i > 5){
		i = i-1;
	}
	Console.WriteLine("Hello World");
}

//9
int i=0;
while(i<60){
	i=i+1;
	int j=0;
	while(j<60){
		j=j+1;
		int k=0;
		while(k<60){
			k=k+1;
			Console.WriteLine("Hello World");
		}
	}
}

//10
int i=0;
while(i<60){
	i=i+1;
	int j=0;
	while(j<60){
		j=j+1;
		Console.WriteLine("Hello World");
		if (j>30){
			i = i+1;
		}
	}
}
