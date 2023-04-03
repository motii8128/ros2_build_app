#!/bin/bash
cd "workdir"
. install/setup.bash
RUN=`ros2 run unity_ros2_test test_sub`

echo $RUN
