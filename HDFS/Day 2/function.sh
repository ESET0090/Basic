#!usr/bin/bash

fun_name () {
           local x=$1
           local y=$2
           result=$(( x + y ))


}

a=3;
b=4;

echo "The sum of the two number's is: "

fun_name $a $b

echo $result 
