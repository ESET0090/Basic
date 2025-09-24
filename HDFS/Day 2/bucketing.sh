#!usr/bin/bash

echo "What's your Name?"
read name

echo "your marks?"
read marks

if [ $marks -lt 25 ]; then
       echo "Bucket 1"
elif [ $marks -lt 50 ]; then
       echo "Bucket 2"
elif [ $marks -lt 75 ]; then
       echo "Bucket 3"
else
       echo "Bucket 4"

fi
