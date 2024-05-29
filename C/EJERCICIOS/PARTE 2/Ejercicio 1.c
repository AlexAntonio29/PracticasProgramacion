//Ejercicio 1    Alexis Zosimo Antonio Angel   102-B 

/*
a, b, p1 y p2 					son: F100, F110, F120 y F130			Alexis Zosimo Antonio Angel   102-B  Programacion estructurada
*/

//apuntadores.c
#include <stdio.h>
void f1(int n){
n *= 2;
printf("%d\n", n);
}
void f2(int *ptr){
*ptr *= 2;
printf("%d\n", *ptr);
}
int main(int argc, char **argv)
{
int a=5, b=7, *p1, *p2;
p1 = &a;
printf("%d\n",a);//5
printf("%d\n",*p1);//5
printf("%p\n",&a);//F100
printf("%p\n",p1);//F100
printf("%p\n\n",&p1);//F120
p2 = p1;
*p2 = 10;
printf("%d\n",a);//10
printf("%d\n",*p1);//10
printf("%d\n",*p2);// 10
printf("%p\n\n",p2);//F100
p2 = &b;
*p2 = 11;
printf("%d\n",a);//10
printf("%d\n",b);//11
printf("%d\n",*p1);//10
printf("%d\n\n",*p2);//11
printf("%p\n",*&p1);//F100
printf("%p\n\n",&*p1);//F120

*p1 = *p2 +a + b + 1;
printf("%d\n",a);//33
printf("%d\n",b);//11
printf("%d\n",*p1);//33
printf("%d\n\n",*p2);//11
a = 5;
printf("%d\n",a);//5
f1(a);//10
printf("%d\n",a);//5
f2(&a);//10
printf("%d\n\n",a);//10
f1(a+b);//42
printf("%d\n",a);//10
f2(&b);//22  b=22
printf("%d\n\n",b);//22
p1 = &a; p2 = &b;
f1(*p1);//20
printf("%d\n",a);//10
f2(p1);//20
printf("%d\n\n",a);//20
f1(*p2 + *p1);//84
printf("%d\n",b);//22
f2(p2);//44
printf("%d\n\n",b);//44
f2(*&p1);//40
printf("%d\n",a);//40
f2(&*p1);//80
printf("%d\n\n",a);//80
return 0;
}
