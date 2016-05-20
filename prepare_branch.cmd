#!/bin/bash
set -x #echo on

git reset head~1 --hard
echo "Bla bla bla" > dummy.txt
git add dummy.txt
git commit -m "Local commit"