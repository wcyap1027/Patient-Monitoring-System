-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 29, 2019 at 09:54 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `patientmonitoringdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `alarm`
--

CREATE TABLE `alarm` (
  `id` int(11) NOT NULL,
  `reading_id` int(11) NOT NULL,
  `alarmLevel` varchar(20) NOT NULL,
  `dateTimeTrigger` datetime NOT NULL,
  `dateTimeMuted` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `bedsidemonitor`
--

CREATE TABLE `bedsidemonitor` (
  `id` int(4) UNSIGNED ZEROFILL NOT NULL,
  `centralStation_id` int(11) NOT NULL,
  `status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `bloodpressure`
--

CREATE TABLE `bloodpressure` (
  `id` int(11) NOT NULL,
  `patient_id` int(11) NOT NULL,
  `bloodPressureValue` double NOT NULL,
  `bloodPressureTime` time NOT NULL,
  `bloodPressureDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `breathingrate`
--

CREATE TABLE `breathingrate` (
  `id` int(11) NOT NULL,
  `patient_id` int(11) NOT NULL,
  `breathingRateValue` double NOT NULL,
  `breathingRateTime` time NOT NULL,
  `breathingRateDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `centralstation`
--

CREATE TABLE `centralstation` (
  `id` int(11) NOT NULL,
  `centralStationName` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `centralstation`
--

INSERT INTO `centralstation` (`id`, `centralStationName`) VALUES
(2001, 'Bay SE'),
(2002, 'Bay NE');

-- --------------------------------------------------------

--
-- Table structure for table `patient`
--

CREATE TABLE `patient` (
  `id` int(11) NOT NULL,
  `NRIC` bigint(12) NOT NULL,
  `fullName` varchar(20) NOT NULL,
  `address` varchar(100) NOT NULL,
  `email` varchar(20) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `phone` int(30) NOT NULL,
  `age` int(11) NOT NULL,
  `bedsideId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `patient`
--

INSERT INTO `patient` (`id`, `NRIC`, `fullName`, `address`, `email`, `gender`, `phone`, `age`, `bedsideId`) VALUES
(1001, 978563421233, 'bob', 'jalan jalan', 'bob@gmail.com', 'Male', 134567819, 17, NULL),
(1002, 956034567890, 'jason', 'jalan t', 'jason@gmail.com', 'Male', 134568812, 18, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `pulserate`
--

CREATE TABLE `pulserate` (
  `id` int(11) NOT NULL,
  `patient_id` int(11) NOT NULL,
  `pulseRateValue` double NOT NULL,
  `pulseRateTime` time NOT NULL,
  `pulseRateDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `reading`
--

CREATE TABLE `reading` (
  `id` int(11) NOT NULL,
  `patient_id` int(11) NOT NULL,
  `minValueBloodPressure` double NOT NULL,
  `maxValueBloodPressure` double NOT NULL,
  `minValueTemperature` double NOT NULL,
  `maxValueTemperature` double NOT NULL,
  `minValueBreathingRate` double NOT NULL,
  `maxValueBreathingRate` double NOT NULL,
  `minValuePulseRate` double NOT NULL,
  `maxValuePulseRate` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `id` int(11) NOT NULL,
  `represent` varchar(20) NOT NULL,
  `position` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`id`, `represent`, `position`) VALUES
(1, 'MS', 'Medical Staff'),
(2, 'MG', 'Management'),
(3, 'C', 'Consultant'),
(4, 'N', 'Nurse');

-- --------------------------------------------------------

--
-- Table structure for table `temperature`
--

CREATE TABLE `temperature` (
  `id` int(11) NOT NULL,
  `patient_id` int(11) NOT NULL,
  `temperatureValue` double NOT NULL,
  `temperatureTime` time NOT NULL,
  `temperatureDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `user_account`
--

CREATE TABLE `user_account` (
  `id` int(11) NOT NULL,
  `role_representative` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `loginStatus` tinyint(1) NOT NULL,
  `dateTimeRegister` datetime NOT NULL,
  `dateTimeLogin` datetime NOT NULL,
  `dateTimeLogOut` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_account`
--

INSERT INTO `user_account` (`id`, `role_representative`, `password`, `loginStatus`, `dateTimeRegister`, `dateTimeLogin`, `dateTimeLogOut`) VALUES
(1001, 'N', '123456', 0, '2019-10-27 00:00:00', '2019-11-29 11:38:46', '2019-10-27 00:00:00'),
(1002, 'N', '123456', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1003, 'N', '123456', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1004, 'N', '123456', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1005, 'N', '123456', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1006, 'C', '3456789', 0, '2019-11-26 00:00:00', '2019-11-29 11:41:16', '2019-11-26 00:00:00'),
(1007, 'C', '3456789', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1008, 'C', '3456789', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1009, 'C', '3456789', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1010, 'C', '3456789', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1011, 'MS', '4567890', 0, '2019-11-26 00:00:00', '2019-11-29 11:43:09', '2019-11-26 00:00:00'),
(1012, 'MS', '4567890', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1013, 'MS', '3456789', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1014, 'MS', '3456789', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1015, 'MS', '3456789', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1016, 'MS', '4567890', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1017, 'MS', '123456', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1018, 'MS', '3456789', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1019, 'MS', '3456789', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1020, 'MS', '3456789', 0, '2019-11-26 00:00:00', '2019-11-26 00:00:00', '2019-11-26 00:00:00'),
(1021, 'MG', '555555', 0, '2019-11-03 00:00:00', '2019-11-29 11:31:27', '2019-11-03 00:00:00'),
(1022, 'MG', '444444', 0, '2019-11-04 00:00:00', '2019-11-29 11:44:48', '2019-11-04 00:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `alarm`
--
ALTER TABLE `alarm`
  ADD PRIMARY KEY (`id`),
  ADD KEY `reading_id` (`reading_id`);

--
-- Indexes for table `bedsidemonitor`
--
ALTER TABLE `bedsidemonitor`
  ADD PRIMARY KEY (`id`),
  ADD KEY `centralStation_id` (`centralStation_id`);

--
-- Indexes for table `bloodpressure`
--
ALTER TABLE `bloodpressure`
  ADD PRIMARY KEY (`id`),
  ADD KEY `patient_id` (`patient_id`);

--
-- Indexes for table `breathingrate`
--
ALTER TABLE `breathingrate`
  ADD PRIMARY KEY (`id`),
  ADD KEY `patient_id` (`patient_id`);

--
-- Indexes for table `centralstation`
--
ALTER TABLE `centralstation`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `NRIC` (`NRIC`);

--
-- Indexes for table `pulserate`
--
ALTER TABLE `pulserate`
  ADD PRIMARY KEY (`id`),
  ADD KEY `patient_id` (`patient_id`);

--
-- Indexes for table `reading`
--
ALTER TABLE `reading`
  ADD PRIMARY KEY (`id`),
  ADD KEY `patient_id` (`patient_id`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `represent` (`represent`);

--
-- Indexes for table `temperature`
--
ALTER TABLE `temperature`
  ADD PRIMARY KEY (`id`),
  ADD KEY `patient_id` (`patient_id`);

--
-- Indexes for table `user_account`
--
ALTER TABLE `user_account`
  ADD PRIMARY KEY (`id`),
  ADD KEY `role_representative` (`role_representative`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `alarm`
--
ALTER TABLE `alarm`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `bedsidemonitor`
--
ALTER TABLE `bedsidemonitor`
  MODIFY `id` int(4) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `bloodpressure`
--
ALTER TABLE `bloodpressure`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `breathingrate`
--
ALTER TABLE `breathingrate`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `centralstation`
--
ALTER TABLE `centralstation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2003;

--
-- AUTO_INCREMENT for table `patient`
--
ALTER TABLE `patient`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1003;

--
-- AUTO_INCREMENT for table `pulserate`
--
ALTER TABLE `pulserate`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `reading`
--
ALTER TABLE `reading`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `temperature`
--
ALTER TABLE `temperature`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user_account`
--
ALTER TABLE `user_account`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1023;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `alarm`
--
ALTER TABLE `alarm`
  ADD CONSTRAINT `alarm - reading_id` FOREIGN KEY (`reading_id`) REFERENCES `reading` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `bedsidemonitor`
--
ALTER TABLE `bedsidemonitor`
  ADD CONSTRAINT `bedsidemonitor - centralStation` FOREIGN KEY (`centralStation_id`) REFERENCES `centralstation` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `bloodpressure`
--
ALTER TABLE `bloodpressure`
  ADD CONSTRAINT `bloodpressure - patient_id` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `breathingrate`
--
ALTER TABLE `breathingrate`
  ADD CONSTRAINT `breathingrate - patient_id` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `pulserate`
--
ALTER TABLE `pulserate`
  ADD CONSTRAINT `pulserate - patient_id` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `temperature`
--
ALTER TABLE `temperature`
  ADD CONSTRAINT `temperature - patient_id` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `user_account`
--
ALTER TABLE `user_account`
  ADD CONSTRAINT `user_account - role_represent` FOREIGN KEY (`role_representative`) REFERENCES `role` (`represent`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
