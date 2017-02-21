

// rewrite these while loops as for loops:
//1

for(int i = 0;i<20; i = i+1){
	Console.WriteLine("Hello World");
}
//2

for(int i = 5;i<=12;i = i+1){
	Console.WriteLine("Hello World");
}
//3

for (int i = 0;i<10;i = i+3){
	Console.WriteLine("Hello World");
}
//4

for (int i = 20;i>=0;i = i-1){
	Console.WriteLine("Hello World");
}
//5

for (int i = 10;i<20;i = i-1){
	Console.WriteLine("Hello World");
	if (i == 5){
		i = 30;
	}
	
}
//6

for (int i = 0;i<20;i = i-1){
	Console.WriteLine("Hello World");
	if (i<-20){
		i = i* -1;
	}
	
}
//7

for (int i = 30;i>15;i = i-3){
	Console.WriteLine("Hello World");
	
}
//8

for (int i = 0;i<100;i = i+i){
	Console.WriteLine("Hello World");
	
}
//9

for (int i = 0;i<5;i = i+i){
	int j = 0
	for (j<4;j = j+1){
		Console.WriteLine("Hello World");		
	}
}
//10

for (int i = 0;i<5;i = i+i){
	int j = 3;
	for (j>0;j = j-1){
		Console.WriteLine("Hello World");
		if (j>i){
			j = j-1;
		}		
	}
	i = i+i;
}