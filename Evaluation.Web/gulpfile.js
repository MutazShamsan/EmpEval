"use strict";

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify");

//var paths = {
//    webroot: "./wwwroot/"
//};

//paths.js = paths.webroot + "js/**/*.js";
//paths.minJs = paths.webroot + "js/**/*.min.js";
//paths.css = paths.webroot + "css/**/*.css";
//paths.minCss = paths.webroot + "css/**/*.min.css";
//paths.concatJsDest = paths.webroot + "js/site.min.js";
//paths.concatCssDest = paths.webroot + "css/site.min.css";


var vendorStyles = [
    "node_modules/bootstrap/dist/css/bootstrap.min.css",
    "node_modules/mdbootstrap/css/mdb.min.css",
    "node_modules/mdbootstrap/css/style.min.css",
    "./wwwroot/css/site.css"
];
var vendorScripts = [
    "node_modules/jquery/dist/jquery.min.js",
    "node_modules/popper.js/dist/umd/popper.min.js",
    "node_modules/bootstrap/dist/js/bootstrap.min.js",
    "node_modules/mdbootstrap/js/mdb.min.js",
    "node_modules/datatables.net/js/jquery.dataTables.min.js"
];

var vendorFonts = [
    "node_modules/jquery/dist/jquery.min.js",
    "node_modules/popper.js/dist/umd/popper.min.js",
    "node_modules/bootstrap/dist/js/bootstrap.min.js",
    "node_modules/mdbootstrap/js/mdb.min.js",
    "node_modules/datatables.net/js/jquery.dataTables.min.js"
];

gulp.task('default', ['build-vendor']);

gulp.task('build-vendor', ['build-vendor-css', 'build-vendor-js']);

gulp.task('build-vendor-css', () => {
    return gulp.src(vendorStyles)
        .pipe(concat('vendor.min.css'))
        .pipe(gulp.dest('wwwroot'));
});

gulp.task('build-vendor-js', () => {
    return gulp.src(vendorScripts)
        .pipe(concat('vendor.min.js'))
        .pipe(gulp.dest('wwwroot'));
});

gulp.task('build-vendor-font', () => {
    return gulp.src(vendorFonts)
        .pipe(concat('vendor.min.js'))
        .pipe(gulp.dest('wwwroot'));
});