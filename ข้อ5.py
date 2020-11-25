#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Wed Nov 25 15:34:33 2020

@author: auttapongkompiban
"""
arr = [1,3,5,7,9,11];
n=1;

for i in range(0,n):
    first  = arr[0];
    for j in range(0,len(arr)-1):
        arr[j] = arr[j+1]
        arr[len(arr)-1] = first
print("Array after left rotation: ");    
for i in range(0, len(arr)):    
    print(arr[i]),    
        
    
    