using System;
using System.Collections.Generic;

[Serializable]
public class ConfigurationData
{
	public int resolution;

	public int screen;

	public int vsync;

	public int scale;

	public int shake;

	public int grid;

	public int object_size;

	public int default_color;

	public int light_system;

	public int light_flicker;

	public int gamepad_sensitivity;

	public int cursor;

	public int selection;

	public int selection_pattern;

	public int selection_opacity;

	public int volume_music;

	public int volume_sounds;

	public int volume_ambience;

	public int anti_aliasing;

	public int ambient_occlusion;

	public int interface_scale;

	public int language;

	public int invert_x_axis;

	public int invert_y_axis;

	public int camera_fov;

	public List<string> unlocked_secrets;

	public List<string> completed_objectives;

	public int stat_objects_placed;

	public int stat_photos_taken;
}
