#include<stdio.h>

void pascal( int n){
	
	int p1[20][20],p2[20][20],i,j,v,k;
	
	for(i=0;i<n;i++){
		
		for(j=0;j<n;j++){
			p1[i][j]=1;
			p2[i][j]=1;
			printf("%d",p1[i][j]);
		}
		printf("\n");
	}	printf("\n\n\n\n");
	
	v=n-1;
	for(i=0;i<n;i++){
		for(k=0;k<((n)-i);k++){
				printf(" ");
				

			}
		for(j=0;j<n-(v-i);j++){
			
			if(j!=0&&j!=(n-(v-i))-1){
				
				
			p1[i][j]=p2[i-1][j]+p2[i-1][j-1];	
				
			}
			p2[i][j]=	p1[i][j];
			
			
			
			
			printf("%d ",p1[i][j]);
			
		}
		printf("\n");
	}


	}


main(){
	int n=10;
	
	pascal(n);
	
	
	return 0;
}
