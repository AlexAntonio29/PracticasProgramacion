 #include <stdio.h>
 
 void recursive(int x){
 	int i=x;
 	
 	printf("%d ",i);
 	i--;
 	
 	
 	if(i!=0)  recursive(i);
 }
 
 
 int main(){
 	
 	recursive(1000000);
 	
 	
 	return 0;
 }