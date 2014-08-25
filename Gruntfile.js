module.exports = function(grunt) {

	grunt.initConfig({
		hub: {
			release: {
				src: ['siteimprove.js'],
				tasks: ['release']
			}
		}
	});

	// Add repo tasks
	grunt.loadNpmTasks('grunt-hub');
	grunt.registerTask('release', ['hub:release']);
	grunt.registerTask('default', ['hub:release']);

};