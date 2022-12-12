import { Box, Typography } from '@mui/material';
import React, { useEffect, useState } from 'react';
import { IoRestaurant } from "react-icons/io5";
import "./styles/comingsoon.css";

const ComingSoon = () => {
    //Timer function
    const calculateTimeLeft = () => {
        let year = new Date().getFullYear();
        let difference = +new Date(`12/01/${year}`) - +new Date();

        let timeLeft = {};

        if (difference > 0) {
            timeLeft = {
                days:    Math.floor(difference / (1000 * 60 * 60 * 24)),
                hours:   Math.floor((difference / (1000 * 60 * 60)) % 24),
                minutes: Math.floor((difference / 1000 / 60) % 60),
                seconds: Math.floor((difference / 1000) % 60)
            };
        }

        return timeLeft;
    };

    const [timeLeft, setTimeLeft] = useState(calculateTimeLeft());
    const [year] = useState(new Date().getFullYear());

    useEffect(() => {
        const timer = setTimeout(() => {
            setTimeLeft(calculateTimeLeft());
        }, 1000);

        return () => clearTimeout(timer);
    });

    const timerComponents = [];
    Object.keys(timeLeft).forEach((interval) => {
        if (!timeLeft[interval]) {
            return;
        }

        timerComponents.push(
            <span>
                {timeLeft[interval]} {interval}{" "}
            </span>
        );
    });


    return (
        <>
            <div className="bgimg">
                <div className="coming-soon-container">
                    <Box sx={{
                        width: 500,
                        height: 250,
                        backgroundColor: '#fffffe',
                        opacity: 0.7,
                        p: 2
                    }}>
                        <Typography variant='h5' sx={{ color: '#121629', mb: 1 }}>
                            Better from Scratch is a fun & vibrant dessert parlor that offers a wide range of baked goods that fit any occasion!
                        </Typography>
                        <Typography variant='body1' sx={{ color: '#121629', fontSize: 15 }}>
                            Tel: +961 1 360 205 
                        </Typography>
                        <Typography variant='body1' sx={{ color: '#121629', fontSize: 15 }}>
                            Mobile: +961 78 965285 
                        </Typography>
                        <Typography variant='body1' sx={{ color: '#121629', fontSize: 15 }}>
                            Address: Clemenceau, Beirut - Lebanon
                        </Typography>
                        <Typography variant='body1' sx={{ color: '#121629', fontSize: 15 }}>
                            Email: contact@better-from-scratch.com
                        </Typography>
                    </Box>
                </div>
            </div>
        </>
    )
}

export default ComingSoon