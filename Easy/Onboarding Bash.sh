# CodinGame planet is being attacked by slimy insectoid aliens.


# game loop
while true; do
    read enemy1
    read dist1
    read enemy2
    read dist2

    # Write an action using echo
    # To debug: echo "Debug messages..." >&2
    if [ $dist2 -lt $dist1 ]; then
        echo $enemy2
    else
        echo $enemy1
    fi

    # echo "enemy" # replace with correct ship name
done