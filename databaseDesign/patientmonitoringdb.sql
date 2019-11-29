-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 29, 2019 at 12:11 PM
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
-- Table structure for table `consultant`
--

CREATE TABLE `consultant` (
  `id` int(5) UNSIGNED ZEROFILL NOT NULL,
  `user_account_id` int(11) NOT NULL,
  `consultant_id` varchar(6) NOT NULL,
  `first_name` varchar(20) NOT NULL,
  `last_name` varchar(20) NOT NULL,
  `NRIC` bigint(12) NOT NULL,
  `address` varchar(100) NOT NULL,
  `email` varchar(30) NOT NULL,
  `phone` int(10) UNSIGNED ZEROFILL NOT NULL,
  `work_status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `consultant`
--

INSERT INTO `consultant` (`id`, `user_account_id`, `consultant_id`, `first_name`, `last_name`, `NRIC`, `address`, `email`, `phone`, `work_status`) VALUES
(00001, 1006, 'C00001', 'Adalee', 'Wong', 324567546345, 'jalan t', 'adalee@gmail.com', 0135467567, 0),
(00002, 1007, 'C00002', 'Liam ', 'Siao', 456732156932, 'jalan r', 'liam@gmail.com', 1658794356, 0),
(00003, 1008, 'C00003', 'James', 'Lord', 345678934512, 'jalan ty', 'james@gmail.com', 0145678341, 0),
(00004, 1009, 'C00004', 'Benjamin', 'Wong', 567898653456, 'jalan rg', 'benjamin@gmail.com', 0156745678, 0),
(00005, 1010, 'C00005', 'Lucas', 'Liew', 456786543214, 'jalan u', 'lucas@gmail.com', 0165345627, 0);

-- --------------------------------------------------------

--
-- Table structure for table `management`
--

CREATE TABLE `management` (
  `id` int(5) UNSIGNED ZEROFILL NOT NULL,
  `user_account_id` int(11) NOT NULL,
  `management_id` varchar(6) NOT NULL,
  `first_name` varchar(20) NOT NULL,
  `last_name` varchar(20) NOT NULL,
  `NRIC` bigint(12) NOT NULL,
  `address` varchar(100) NOT NULL,
  `email` varchar(30) NOT NULL,
  `phone` int(10) UNSIGNED ZEROFILL NOT NULL,
  `work_status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `management`
--

INSERT INTO `management` (`id`, `user_account_id`, `management_id`, `first_name`, `last_name`, `NRIC`, `address`, `email`, `phone`, `work_status`) VALUES
(00001, 1021, 'MG0001', 'Micheal', 'Shiao', 567434567812, 'jalan jalan', 'micheal@gmail.com', 0138906571, 0),
(00002, 1022, 'MG0002', 'Oliver', 'Lee', 976543245612, 'jalan jalan', 'oliver@gmail.com', 0156789990, 0);

-- --------------------------------------------------------

--
-- Table structure for table `medicalstaff`
--

CREATE TABLE `medicalstaff` (
  `id` int(5) UNSIGNED ZEROFILL NOT NULL,
  `user_account_id` int(11) NOT NULL,
  `medicalStaff_id` varchar(20) NOT NULL,
  `first_name` varchar(20) NOT NULL,
  `last_name` varchar(20) NOT NULL,
  `NRIC` bigint(20) NOT NULL,
  `address` varchar(100) NOT NULL,
  `email` varchar(30) NOT NULL,
  `phone` int(10) UNSIGNED ZEROFILL NOT NULL,
  `work_status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `medicalstaff`
--

INSERT INTO `medicalstaff` (`id`, `user_account_id`, `medicalStaff_id`, `first_name`, `last_name`, `NRIC`, `address`, `email`, `phone`, `work_status`) VALUES
(00001, 1011, 'MS00001', 'Abby', 'Wong', 978656789765, 'jalan o', 'abby@gmail.com', 0198098765, 0),
(00002, 1012, 'MS00002', 'Abi', 'Tan', 876545679876, 'jalan wahyu', 'abi@gmail.com', 0136578791, 0),
(00003, 1013, 'MS00003', 'Kylo', 'Wong', 879767845678, 'jalan you', 'kylo@gmail.com', 0145766784, 0),
(00004, 1014, 'MS00004', 'Kenzo', 'Tan', 987656783456, 'jalan halo', 'kenzo@gmail.com', 0145678980, 0),
(00005, 1015, 'MS00005', 'Watson', 'Liew', 908765432213, 'jalan k', 'watson@gmail.com', 0156789940, 0),
(00006, 1016, 'MS00006', 'Baker', 'Wong', 987675432100, 'jalan we', 'baker@gmail.com', 0147896554, 0),
(00007, 1017, 'MS00007', 'Amias', 'Lee', 987634521091, 'jalan hu', 'amias@gmail.com', 0157658900, 0),
(00008, 1018, 'MS00008', 'Mason', 'Lee', 912345678910, 'jalan w', 'mason@gmail.com', 0156789110, 0),
(00009, 1019, 'MS00009', 'Logan', 'Wong', 954352163443, 'jalan r', 'logan@gmail.com', 0156789901, 0),
(00010, 1020, 'MS00010', 'Ethan', 'Lee', 657843216789, 'jalan n', 'ethan@gmail.com', 0135678990, 0);

-- --------------------------------------------------------

--
-- Table structure for table `nurse`
--

CREATE TABLE `nurse` (
  `id` int(5) UNSIGNED ZEROFILL NOT NULL,
  `user_account_id` int(11) NOT NULL,
  `nurse_id` varchar(20) NOT NULL,
  `first_name` varchar(20) NOT NULL,
  `last_name` varchar(20) NOT NULL,
  `NRIC` bigint(20) NOT NULL,
  `address` varchar(100) NOT NULL,
  `email` varchar(30) NOT NULL,
  `phone` int(10) UNSIGNED ZEROFILL NOT NULL,
  `work_status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `nurse`
--

INSERT INTO `nurse` (`id`, `user_account_id`, `nurse_id`, `first_name`, `last_name`, `NRIC`, `address`, `email`, `phone`, `work_status`) VALUES
(00001, 1001, 'N00001', 'Amy', 'Wong', 920945673211, 'jalan utar', 'amywong@gmail.com', 0134567891, 0),
(00002, 1002, 'N00002', 'Emelia', 'Tan', 345612348901, 'jalan loke yew', 'emelia@gmail.com', 0113245890, 0),
(00003, 1003, 'N00003', 'Ava ', 'Tan', 657894301234, 'jalan wahyu', 'ava@gmail.com', 0134567421, 0),
(00004, 1004, 'N00004', 'Isabella', 'Tan', 9876543211234, 'jalan jalan', 'isabella@gmail.com', 0124567845, 0),
(00005, 1005, 'N00005', 'Sophia', 'Lee', 456234689432, 'jalan k', 'sophia@gmail.com', 0146732567, 0);

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
(1001, 978563421234, 'Bob', 'jalan jalan', 'bob1234@gmail.com', 'Male', 134567819, 17, 0),
(1002, 956034567890, 'Jason', 'jalan t', 'jason4576@gmail.com', 'Male', 134568812, 18, 0);

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
-- Indexes for table `consultant`
--
ALTER TABLE `consultant`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `consultant_id` (`consultant_id`),
  ADD UNIQUE KEY `NRIC` (`NRIC`),
  ADD KEY `user_account_id` (`user_account_id`);

--
-- Indexes for table `management`
--
ALTER TABLE `management`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `management_id` (`management_id`),
  ADD UNIQUE KEY `NRIC` (`NRIC`),
  ADD KEY `user_account_id` (`user_account_id`);

--
-- Indexes for table `medicalstaff`
--
ALTER TABLE `medicalstaff`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nurse_id` (`medicalStaff_id`),
  ADD UNIQUE KEY `NRIC` (`NRIC`),
  ADD UNIQUE KEY `user_account_id` (`user_account_id`) USING BTREE;

--
-- Indexes for table `nurse`
--
ALTER TABLE `nurse`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `NRIC` (`NRIC`),
  ADD UNIQUE KEY `nurse_id` (`nurse_id`),
  ADD KEY `user_account_id` (`user_account_id`);

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
-- AUTO_INCREMENT for table `consultant`
--
ALTER TABLE `consultant`
  MODIFY `id` int(5) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `management`
--
ALTER TABLE `management`
  MODIFY `id` int(5) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `medicalstaff`
--
ALTER TABLE `medicalstaff`
  MODIFY `id` int(5) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `nurse`
--
ALTER TABLE `nurse`
  MODIFY `id` int(5) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

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
-- Constraints for table `consultant`
--
ALTER TABLE `consultant`
  ADD CONSTRAINT `consultant - user_account_id` FOREIGN KEY (`user_account_id`) REFERENCES `user_account` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `management`
--
ALTER TABLE `management`
  ADD CONSTRAINT `management - user_account_id` FOREIGN KEY (`user_account_id`) REFERENCES `user_account` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `medicalstaff`
--
ALTER TABLE `medicalstaff`
  ADD CONSTRAINT `medicalStaff - user_account_id` FOREIGN KEY (`user_account_id`) REFERENCES `user_account` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `nurse`
--
ALTER TABLE `nurse`
  ADD CONSTRAINT `nurse - user_account_id` FOREIGN KEY (`user_account_id`) REFERENCES `user_account` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

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
