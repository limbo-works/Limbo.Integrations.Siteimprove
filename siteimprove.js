var projectNumb='siteimprove';
module.exports = function(grunt) {
	grunt.initConfig({
		pkg: grunt.file.readJSON('package.json'),
		copy: {
			release: {
				files: [
					{
						expand: true,
						cwd: 'src/Skybrud.Siteimprove/bin/Release',
						src: ['*.dll'],
						dest: 'files/bin'
					}
				]
			}
		}
	});

	grunt.loadNpmTasks('grunt-contrib-copy');
	grunt.loadNpmTasks('grunt-contrib-watch');

	grunt.registerTask('default', ['copy:release']);
	grunt.registerTask('release',['copy:release']);

};