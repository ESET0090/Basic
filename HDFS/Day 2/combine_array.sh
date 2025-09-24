#!usr/bin/bash

array1=("apple" "banana")
array2=("data" "fig")


combined_array=("${array1[@]}" "${array2[@]}")

echo "Combined array: ${combined_array[@]}"




