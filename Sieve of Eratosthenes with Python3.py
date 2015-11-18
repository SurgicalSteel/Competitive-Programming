#-------------------------------------------------------------------------------
# Name:        Sieve of Eratosthenes
# Purpose:
#
# Author:      Yuwono Bangun Nagoro
#
# Created:     18/11/2015
# Copyright:   (c) Yuwono Bangun Nagoro 2015
# Licence:     <your licence>
#-------------------------------------------------------------------------------
def sieve_of_Eratosthenes(x):
    a=1
    for i in range(2,x+1) :
        for j in range (2,i+1) :
                if i%j==0 :
                   a+=1
        if a==2 :
           print(i)
        a=1

sieve_of_Eratosthenes(10000)
